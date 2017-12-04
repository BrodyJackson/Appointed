using Appointed.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Appointed.ViewModels;
using Appointed.Views.Sidebar.Widgets;
using System.Windows.Controls.Primitives;

namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for AlertBoxView.xaml
    /// </summary>
    public partial class AlertBoxView : UserControl
    {
        List<Alert> _alerts = new List<Alert>();
        Dictionary<string, WaitlistEventArgs> _alertParams = new Dictionary<string, WaitlistEventArgs>();

        Alert activeAlert;

        public AlertBoxView()
        {
            InitializeComponent();

            this.Loaded += AlertBoxViewLoaded;
        }


        private void AlertBoxViewLoaded(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            DIVM.WaitlistAlert += OnWaitlistSpotOpen;
            UpdateAlertsBox();
        }


        // sender is the appt that was deleted.
        // e has information on the slot for the date and doctor that just opened as well as the key
        // for the appt that was next in line for that spot.
        private void OnWaitlistSpotOpen(object sender, WaitlistEventArgs e)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;
            Alert alert = new Alert();

            Appointment a = DIVM.AVM._appointmentLookup[e.Key];

            alert.ButtonText = "Reschedule";
            alert.OnActionButtonClick += OnRescheduleAppointment;
            alert.Title = "Appt Bump Available For " + a.PatientNameAbbrev;
            alert.OnDeleteButtonClick += OnRemoveAlert;
            alert.WLE = e;

            DIVM.SVM.AddWaitlistAlert(alert);
        }

   
        // Pass in the alert as the sender
        private void OnRescheduleAppointment(object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;
            Alert a = sender as Alert;

            activeAlert = a;

            Appointment apptToReschedule = DIVM.AVM._appointmentLookup[a.WLE.Key];

            string currDay = DIVM.GetDayString(apptToReschedule.DateTime.Value.Day);
            string currMonth = DIVM.GetMonthString(apptToReschedule.DateTime.Value.Month);
            string currYear = apptToReschedule.DateTime.Value.Year.ToString();
            string currStart = apptToReschedule.StartTimeStr;

            string newDay = DIVM.GetDayString(a.WLE.Date.Day);
            string newMonth = DIVM.GetMonthString(a.WLE.Date.Month);
            string newYear = a.WLE.Date.Year.ToString();
            string newStart = a.WLE.Date.Time24Hr.ToString();
            newStart = newStart.Insert(newStart.Length - 2, ":");

            RescheduleConfirmation r = new RescheduleConfirmation();
            r.TypeNameTextCurrent.Text = "Appointment for " + apptToReschedule.Patient + " with " + apptToReschedule.DoctorName;
            r.DateTimeTextCurrent.Text =
                "On " + currDay + ", " + currMonth + " " + apptToReschedule.DateTime.Value.Day + ", " + currYear + " at " + currStart;

            r.TypeNameTextNew.Text =  "Appointment for " + apptToReschedule.Patient + " with " + a.WLE.DoctorName;
            r.DateTimeTextNew.Text =
                 "On " + newDay + ", " + newMonth + " " + a.WLE.Date.Day + ", " + newYear + " at " + newStart;


            SidebarFrameView s = ((App.Current.MainWindow as Home).SidebarView) as SidebarFrameView;
            HomeSidebar h = s.SidebarGridLayout.Children.OfType<HomeSidebar>().ElementAt(0);

            Popup popup = new Popup
            {
                Child = r,
                StaysOpen = true,
                AllowsTransparency = true,
                PlacementTarget = h.AlertBox,
                Placement = PlacementMode.Right,
                VerticalOffset = 50
            };


            popup.IsOpen = true;

            r.RescheduleButton.Click += OnDoReschedule;            
        }


        private void OnDoReschedule(object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;

            DIVM.AVM.RescheduleAppointment(activeAlert);
            DIVM.SVM.RemoveAlert(activeAlert);

            Home home = App.Current.MainWindow as Home;
            home.SidebarView.SetSidebarView(new HomeSidebar());
        }



        private void OnRemoveAlert(object sender, EventArgs e)
        {
            MessageBoxResult result =
                MessageBox.Show
                (
                    "Are you sure you wish to remove this appointment from the waitlist?",
                    "Confirm Selection",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Asterisk
                );

            if (result == MessageBoxResult.No || result == MessageBoxResult.None)
                return;


            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;

            Alert a = sender as Alert;
            DIVM.SVM.RemoveAlert(a);

            int key = new DateTime(a.WLE.Date.Year, a.WLE.Date.Month, a.WLE.Date.Day, a.WLE.Date.Time24Hr / 100, a.WLE.Date.Time24Hr % 100, 0).GetHashCode();
            key += DIVM.AVM.FindDrColumnForDrName(a.WLE.DoctorName);

            Appointment apptToRemove = DIVM.AVM._appointmentLookup[a.WLE.Key];
            apptToRemove.Waitlisted = false;
            //DIVM.WaitList.RemoveAppointment(apptToRemove);

            Appointment freeApptSlot = DIVM.AVM._appointmentLookup[key];
            DIVM.FreeAppointmentSlot(freeApptSlot);

            Home home = App.Current.MainWindow as Home;
            home.SidebarView.SetSidebarView(new HomeSidebar());
        }


        public void AddAlert(Alert a)
        {
            _alerts.Insert(_alerts.Count, a);
        }

        public void RemoveAlert(Alert a)
        {
            _alerts.Remove(a);
        }

        public void UpdateAlertsBox()
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;
            AlertsList.Children.Clear();

            //foreach(Alert a in _alerts)
            //{
            //    ListItems.Alert alert = new ListItems.Alert(a, this);
            //    AlertsList.Children.Add(alert);
            //}

            foreach (KeyValuePair<int, Alert> entry in DIVM.SVM.WaitlistAlerts)
            {
                ListItems.Alert alert = new ListItems.Alert(entry.Value, this);
                AlertsList.Children.Add(alert);
            }
        }

    }
}
