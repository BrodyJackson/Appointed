
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
using Appointed.Classes;
using Appointed.ViewModels;

namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NewAppointmentSidebar : UserControl
    {
        public NewAppointmentSidebar()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(NewAppointmentSidebar_Loaded);
        }


        void NewAppointmentSidebar_Loaded(object sender, RoutedEventArgs e)
        {
            (this.DataContext as DayInformationViewModel)._activeDate.ActiveDateChanged += ActiveDateChanged;

            ApptTypeComboBox.SelectionChanged += ComboBox_ApptTypeSelectionChanged;

            ActiveDateChanged(null, null);
        }


        private void ActiveDateChanged(object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            if (DIVM != null && DIVM.AVM._activeAppointment != null)
            {
                DatePicker.InputText.TextField.Text = DIVM.AVM._activeAppointment.DateTimeStr;
                WaitlistDatePicker.InputText.TextField.Text = DIVM.AVM._activeAppointment.DateTimeStr;
            }
        }

        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {
            Home h = App.Current.MainWindow as Home;

            h.SidebarView.SetSidebarView(new SearchResultsSidebar());
        }

        //need to add a function so that when the sidebar loads, it takes the value that is passed in as the active patient


        private void ComboBox_WaitlistTimeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WaitlistStartTime.SelectedItem == null || ApptTypeComboBox.SelectedItem == null)
            {
                Console.WriteLine("Gotcha: \n");
                return;
            }

            if (((ApptTypeComboBox.SelectedItem as ComboBoxItem).Content as string) == "Standard")
            {
                WaitlistEndTime.Text = DateTime.Parse((WaitlistStartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToShortTimeString();
            }
            else
            {
                WaitlistEndTime.Text = DateTime.Parse((WaitlistStartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToShortTimeString();
            }
        }

        private void ComboBox_TimeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StartTime.SelectedItem == null || ApptTypeComboBox.SelectedItem == null)
            {
                Console.WriteLine("Gotcha: \n");
                return;
            }

            if (((ApptTypeComboBox.SelectedItem as ComboBoxItem).Content as string) == "Standard")
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToShortTimeString();
            }
            else
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToShortTimeString();
            }
        }

        // Forces the appt end time/s to update when the appt type is changed.
        private void ComboBox_ApptTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox_TimeSelectionChanged(null, null);
            ComboBox_WaitlistTimeSelectionChanged(null, null);
        }


        private void OnMouseLeftRelease_Save(object sender, MouseButtonEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            //don't think I need active appointment, will make when done gettting values from boxes
            Appointment targetAppointment = null;
            Appointment apptThatFollowsTarget = null;

            string stTime = ((Time)StartTime.SelectedItem).TimeString;
            stTime = stTime.Substring(0, stTime.IndexOf(':')) + stTime.Substring(stTime.IndexOf(':') + 1);

            string endTime = EndTime.Text;
            endTime = endTime.Substring(0, endTime.IndexOf(':')) + endTime.Substring(endTime.IndexOf(':') + 1, 2);

            string type = ApptTypeComboBox.SelectedValue.ToString();
            type = type.Substring(type.LastIndexOf(':') + 2); //ask what this does

            string drName = ((Doctor)DoctorComboBox.SelectedItem).DoctorName;
            string dateString = DatePicker.InputText.TextField.Text;

            // Build the key to look up the appointment slot they wish to book in.
            int time = Int32.Parse(stTime);

            // The hashcode of the DateTime + <DrColumn> form the key for appointment lookups.
            DateTime dt = getDateTime(time, dateString);
            int drColumn = DIVM.AVM.FindDrColumnForDrName(drName);
            int key = dt.GetHashCode() + drColumn;

            targetAppointment = DIVM.AVM._appointmentLookup[key];
            if (targetAppointment != null)
            {
                if (type == "Consultation")
                    apptThatFollowsTarget = DIVM.AVM.FindAppointmentThatFollows(targetAppointment);

                if ((targetAppointment.Type != "") || (type == "Consultation" && apptThatFollowsTarget.Type != ""))
                {
                    MessageBox.Show(
                        "The Time Slot Specified Is Taken!",
                        "Unable to Modify Appointment",
                        MessageBoxButton.OK,
                        MessageBoxImage.Asterisk);

                    return;
                }

                if ((!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(Int32.Parse(stTime))) ||
                        (!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(Int32.Parse(endTime))))
                {
                    MessageBox.Show(
                        "The Doctor Specified Is Unavaliable At That Time!",
                        "Unable to Modify Appointment",
                        MessageBoxButton.OK,
                        MessageBoxImage.Asterisk);

                    return;
                }


            }


            Appointment _newAppointment = DIVM.AVM._appointmentLookup[key];

            _newAppointment.ID = key.ToString();
            _newAppointment.Margin = "0,1,0,0";
            _newAppointment.DoctorName = ((Doctor)DoctorComboBox.SelectedItem).DoctorName;
            _newAppointment.Colour = DIVM.AVM.FindDrColourForDrName(_newAppointment.DoctorName);
            _newAppointment.Cursor = "Hand";
            _newAppointment.DateTime = dt;
            _newAppointment.IsClickable = "True";
            _newAppointment.Missed = false;
            _newAppointment.Arrived = false;

            if ((bool)AddToWaitlistCheckBox.IsChecked)
            {
                dateString = WaitlistDatePicker.InputText.TextField.Text;

                stTime = ((Time)WaitlistStartTime.SelectedItem).TimeString;
                stTime = stTime.Substring(0, stTime.IndexOf(':')) + stTime.Substring(stTime.IndexOf(':') + 1);
                time = Int32.Parse(stTime);

                DateTime date = getDateTime(time, dateString);

                drName = ((Doctor)WaitlistDoctorComboBox.SelectedItem).DoctorName;

                _newAppointment.WaitlistPos = DIVM.WaitList.AddAppointment(_newAppointment, date, drName).ToString();
                _newAppointment.Waitlisted = true;
            }

            _newAppointment.Type = type;
            _newAppointment.StartTime = Int32.Parse(stTime);
            _newAppointment.EndTime = Int32.Parse(endTime);
            _newAppointment.ReminderType = ((ComboBoxItem)RemType.SelectedItem).Content.ToString();
            _newAppointment.ReminderTimeOfDay = ((ComboBoxItem)RemTOD.SelectedItem).Content.ToString();
            _newAppointment.ReminderDays = ((ComboBoxItem)RemDays.SelectedItem).Content.ToString();
            _newAppointment.Comments = CommentBox.Text;
            _newAppointment.Height = (type == "Consultation" ? "70" : "35");
            _newAppointment.Patient = DIVM.PVM.ActivePatient.FirstName + " " + DIVM.PVM.ActivePatient.LastName;
            //I tried to make this update to the active patient value that will be set by search bar
            _newAppointment.Opacity = "0.4";
            _newAppointment.Visibility = "Visible";

            if (_newAppointment.Type == "Consultation")
                apptThatFollowsTarget.Visibility = "Collapsed";


            DIVM.PVM.ActivePatient.AddUpcommingAppointment(key);
            DIVM.AVM._activeAppointment = new Appointment(_newAppointment);

            Home h = App.Current.MainWindow as Home;
            h.SidebarView.SetSidebarView(new AppointmentDetailsSidebar());
        }





        public DateTime getDateTime(int startTime, string yearMonthDay)
        {
            int year = Int32.Parse(yearMonthDay.Substring(0, yearMonthDay.IndexOf('-')));

            int firstInd = yearMonthDay.IndexOf('-') + 1;
            int secondInd = yearMonthDay.LastIndexOf('-');
            int month = Int32.Parse(yearMonthDay.Substring(firstInd, secondInd - firstInd));

            int day = Int32.Parse(yearMonthDay.Substring(yearMonthDay.LastIndexOf('-') + 1));

            return new DateTime(year, month, day, startTime / 100, startTime % 100, 0);
        }
       
        

    }

}
