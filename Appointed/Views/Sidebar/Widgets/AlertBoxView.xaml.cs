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

namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for AlertBoxView.xaml
    /// </summary>
    public partial class AlertBoxView : UserControl
    {
        List<Alert> _alerts = new List<Alert>();
        Dictionary<string, WaitlistEventArgs> _alertParams = new Dictionary<string, WaitlistEventArgs>();

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

            MessageBoxResult result =
                MessageBox.Show
                (
                    "Are you sure you wish to reschedule this appointment?\nTo undo, you must delete it and start over.\n\n",
                    "Confirm Selection",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Asterisk
                );

            if (result == MessageBoxResult.No || result == MessageBoxResult.None)
                return;

            Alert a = sender as Alert;

            DIVM.AVM.RescheduleAppointment(a);
            DIVM.SVM.RemoveAlert(a);

            Home h = App.Current.MainWindow as Home;
            h.SidebarView.SetSidebarView(new HomeSidebar());
        }
        


        private void OnRemoveAlert(object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Alert a = sender as Alert;

            DIVM.SVM.RemoveAlert(a);
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
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
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
