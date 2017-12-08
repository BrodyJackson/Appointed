using Appointed.Classes;
using Appointed.ViewModels;
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
using static Appointed.Views.Controls.InputText;

namespace Appointed.Views.Sidebar.ListItems
{
    /// <summary>
    /// Interaction logic for SearchResult.xaml
    /// </summary>
    public partial class SearchResult : UserControl
    {
        private Patient patient;
        public Patient Patient
        {
            get { return patient; }
            set
            {
                patient = value;
                PatientName.Text = patient.LastName + ", " + patient.FirstName;
                if (patient.MiddleName.Length > 0) PatientName.Text += " " + patient.MiddleName[0] + ".";
                PatientID.Text = new HealthCareIDMask().FormatText(patient.HealthID.ToString());
                PatientSex.Text = "Sex: " + patient.GetSexAsString();
                PatientBirthday.Text = "Birthdate: " + patient.BirthDate.ToShortDateString();

                AbbreviatePatientName();
            }
        }


        private void AbbreviatePatientName()
        {
            string abbreviatedName = PatientName.Text;
            int whiteSpaceIndex;

            if (PatientName.Text.Length > 18)
            {
                whiteSpaceIndex = PatientName.Text.IndexOf(' ');
                abbreviatedName = PatientName.Text.ElementAt(0).ToString() + "." + PatientName.Text.Substring(whiteSpaceIndex);
            }

            if (abbreviatedName.Length > 18)
            {
                whiteSpaceIndex = abbreviatedName.IndexOf(' ');
                abbreviatedName = abbreviatedName.Substring(0, whiteSpaceIndex) + " " + abbreviatedName.Substring(whiteSpaceIndex + 1, 8) + "..";
            }

            PatientName.Text = abbreviatedName;
        }

        public SearchResult(Patient p)
        {
            InitializeComponent();

            Patient = p;

            BookApptBtn.Click += BookApptBtn_Click;
            MoreInfoBtn.Click += MoreInfoBtn_Click;

            if (patient.GetUpcomingAppointmentKeys().Count > 0)
            {
                NextApptBtn.Click += NextApptBtn_Click;
            }
            else
            {
                NextApptBtn.IsEnabled = false;
            }
        }

        private void NextApptBtn_Click(object sender, RoutedEventArgs e)
        {
            if (patient.GetUpcomingAppointmentKeys().Count > 0)
            {
                int nextApptKey = patient.GetUpcomingAppointmentKeys()[0];

                DayInformationViewModel DIVM = (App.Current.MainWindow.DataContext as DayInformationViewModel);

                Appointment nextAppt = DIVM.AVM._appointmentLookup[nextApptKey];
                DateTime activeDT = new DateTime(DIVM._activeDate.Year, DIVM._activeDate.Month, DIVM._activeDate.Day);
                DateTime nextDT = nextAppt.DateTime.Value;
                activeDT = new DateTime(activeDT.Year, activeDT.Month, activeDT.Day, nextDT.Hour, nextDT.Minute, nextDT.Second);

                TimeSpan diff = nextAppt.DateTime.Value - activeDT.AddDays(1);

                if (Math.Abs(diff.Days) > 0)
                    if (DIVM.ShiftView.CanExecute(null))
                        DIVM.ShiftView.Execute(diff.Days);

                int amount = nextAppt.StartTime;
                amount -= 700;
                amount = ((amount / 100) * 4) + ((amount % 100) / 15);

                (App.Current.MainWindow as Home).ThreeDayView.ScrollSchedule(amount);

                nextAppt.Colour = "Red";
                nextAppt.Opacity = "1.0";
                DIVM.AVM._nextAppointment = nextAppt;
            }

        }

        private void MoreInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient = patient;
            (App.Current.MainWindow as Home).SidebarView.SetSidebarView(new PatientInfoSidebar(patient));
        }

        private void BookApptBtn_Click(object sender, RoutedEventArgs e)
        {
            (App.Current.MainWindow.DataContext as DayInformationViewModel).PVM.ActivePatient = patient;
            (App.Current.MainWindow as Home).SidebarView.SetSidebarView(new NewAppointmentSidebar());
        }

    }
}
