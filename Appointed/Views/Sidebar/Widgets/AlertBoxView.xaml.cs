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

            AddWaitlistAlert(alert, e);
            UpdateAlertsBox();
        }

   
        // Pass in the alert as the sender
        private void OnRescheduleAppointment(object sender, EventArgs e)
        {
            MessageBoxResult result =
                MessageBox.Show
                (
                    "Are you sure you wish to reschedule this appointment?\nTo undo, you must delete it start over.",
                    "Confirm Selection",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Asterisk
                );

            if (result == MessageBoxResult.No || result == MessageBoxResult.None)
                return;

            Alert a = sender as Alert;

            WaitlistEventArgs wle = _alertParams[a.Title];

            bumpAppointment(wle.Key, wle.DoctorName, wle.Date);
        }


        // Finds the appointment to be bumped by it's key.
        // Changes it's time slot and doctor according to the other parameters.
        private void bumpAppointment(int key, string drName, Date date)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Appointment apptToRelocate = DIVM.AVM._appointmentLookup[key];
            Appointment apptThatFollows = null;

            if (apptToRelocate.Type == "Consultation")
            {
                apptThatFollows = DIVM.AVM.FindAppointmentThatFollows(apptToRelocate);
                if (apptThatFollows.Type != "")
                    return;
            }

            DateTime dt = new DateTime(date.Year, date.Month, date.Day, date.Time24Hr / 100, date.Time24Hr % 100, 0);

            apptToRelocate.DoctorName = drName;
            apptToRelocate.Colour = DIVM.AVM.FindDrColourForDrName(apptToRelocate.DoctorName);
            apptToRelocate.DateTime = dt;
            apptToRelocate.StartTime = date.Time24Hr;
            apptToRelocate.EndTime = apptToRelocate.StartTime + (apptToRelocate.Type == "Consultation" ? 30 : 15);
            apptToRelocate.Waitlisted = false;

        }


        // If the alert removed corresponds to a waitlisted item, I need to signal to the DIVM
        // that an appointment slot may be open.
        private void OnRemoveAlert(object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Alert a = sender as Alert;

            if (_alertParams.ContainsKey(a.Title))
            {
                Appointment appt = DIVM.AVM._appointmentLookup[_alertParams[a.Title].Key];
                DIVM.FreeAppointmentSlot(appt);
            }
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
            AlertsList.Children.Clear();

            foreach(Alert a in _alerts)
            {
                ListItems.Alert alert = new ListItems.Alert(a, this);
                AlertsList.Children.Add(alert);
            }
        }



        private void AddWaitlistAlert(Alert a, WaitlistEventArgs e)
        {
            AddAlert(a);
            _alertParams[a.Title] = e;
        }

    }
}
