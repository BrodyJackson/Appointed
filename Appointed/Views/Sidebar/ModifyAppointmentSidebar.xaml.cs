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
using System.Windows.Shapes;
using Appointed.ViewModels;
using Appointed.Classes;


namespace Appointed.Views.Sidebar
{
    /// <summary>
    /// Interaction logic for ModifyAppointmentDialog.xaml
    /// </summary>
    public partial class ModifyAppointmentSidebar : UserControl
    {
        private bool _reminderEnabled = true;


        public ModifyAppointmentSidebar()
        {
            InitializeComponent();
            ReminderToggle.IsChecked = true;


            this.Loaded += new RoutedEventHandler(ModifyAppointmentSidebar_Loaded);
        }

        
        void ModifyAppointmentSidebar_Loaded(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            DIVM._activeDate.ActiveDateChanged += ActiveDateChanged;

            StartTime.SelectionChanged += DIVM.HighlightDate;
            DoctorComboBox.SelectionChanged += DIVM.HighlightDate;
            ApptTypeComboBox.SelectionChanged += DIVM.HighlightDate;

            ActiveDateChanged(null, null);
        }



        private void ActiveDateChanged(object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;

            if (DIVM != null && DIVM.AVM._activeAppointment != null)
            {
                DatePicker.InputText.TextField.Text = DIVM.AVM._activeAppointment.DateTimeStr;
            }
        }




        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result =
                MessageBox.Show
                (
                    "Are you sure you wish to discard your changes?",
                    "Confirm Selection",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Asterisk
                );

            if (result == MessageBoxResult.No || result == MessageBoxResult.None)
                return;

            Home h = App.Current.MainWindow as Home;
            h.SidebarView.SetSidebarView(new AppointmentDetailsSidebar());
        }


        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            _reminderEnabled = !_reminderEnabled;

            RemDaysLable.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemTODLable.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemType.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemTypeLable.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemTOD.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
            RemDays.Visibility = _reminderEnabled ? Visibility.Visible : Visibility.Hidden;
        }



        private void ComboBox_StartTimeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StartTime.SelectedItem == null || ApptTypeComboBox.SelectedItem == null)
            {
                Console.WriteLine("Gotcha: \n");
                return;
            }

            if (((ApptTypeComboBox.SelectedItem as ComboBoxItem).Content as string) == "Standard")
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Time).TimeString).AddMinutes(15).ToShortTimeString();
            }
            else
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Time).TimeString).AddMinutes(30).ToShortTimeString();
            }
        }


        private void ComboBox_ApptTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox_StartTimeSelectionChanged(null, null);
        }



        private void OnMouseLeftRelease_Save(object sender, MouseButtonEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Appointment activeAppt = DIVM.AVM._appointmentLookup[Int32.Parse(DIVM.AVM._activeAppointment.ID)];
            Appointment targetAppointment = null;
            Appointment apptThatFollowsTarget = null;

            // BEGIN PARSE DATA FROM SIDEBAR FIELDS
            string stTime = ((Time)StartTime.SelectedItem).TimeString;
            stTime = stTime.Substring(0, stTime.IndexOf(':')) + stTime.Substring(stTime.IndexOf(':') + 1);
//          string timeCmp = stTime;

            string endTime = EndTime.Text;
            endTime = endTime.Substring(0, endTime.IndexOf(':')) + endTime.Substring(endTime.IndexOf(':') + 1, 2);

            string type = ApptTypeComboBox.SelectedValue.ToString();
            type = type.Substring(type.LastIndexOf(':') + 2);

            string drName = ((Doctor)DoctorComboBox.SelectedItem).DoctorName;
            string dateString = DatePicker.InputText.TextField.Text;

            // Build the key to look up the appointment slot they wish to book in.
            int time = Int32.Parse(stTime);
            int year = Int32.Parse(dateString.Substring(0, dateString.IndexOf('-')));

            int firstInd = dateString.IndexOf('-') + 1;
            int secondInd = dateString.LastIndexOf('-');
            int month = Int32.Parse(dateString.Substring(firstInd, secondInd - firstInd));

            int day = Int32.Parse(dateString.Substring(dateString.LastIndexOf('-') + 1));
            // END PARSE DATA FROM SIDEBAR FIELDS


            // The hashcode of the DateTime + <DrColumn> form the key for appointment lookups.
            DateTime dt = new DateTime(year, month, day, time / 100, time % 100, 0);
            int drColumn = DIVM.AVM.FindDrColumnForDrName(drName);
            int key = dt.GetHashCode() + drColumn;

            targetAppointment = DIVM.AVM._appointmentLookup[key];
            apptThatFollowsTarget = DIVM.AVM.FindAppointmentThatFollows(targetAppointment);
            if (targetAppointment != null && targetAppointment != activeAppt)
            {
                if ((targetAppointment.Type != "")   ||
                    (type == "Consultation" && apptThatFollowsTarget.Type != ""  && apptThatFollowsTarget != activeAppt))
                {
                    MessageBox.Show(
                        "The Time Slot Specified Is Taken!",
                        "Unable to Modify Appointment",
                        MessageBoxButton.OK,
                        MessageBoxImage.Asterisk);

                    return;
                }

                int sTime = Int32.Parse(stTime); int eTime = Int32.Parse(endTime); if (eTime < sTime) eTime += 1200; 

                if ((!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(sTime)) ||
                        (!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(eTime)))
                {
                    MessageBox.Show(
                        "The Doctor Specified Is Unavaliable At That Time!",
                        "Unable to Modify Appointment",
                        MessageBoxButton.OK,
                        MessageBoxImage.Asterisk);

                    return;
                }
            }


            DIVM.ResetHighlightedAppointment();
            DIVM._activeDate.HasChanged = false;


            targetAppointment.DoctorName = ((Doctor)DoctorComboBox.SelectedItem).DoctorName;
            targetAppointment.Type = type;    
            targetAppointment.StartTime = Int32.Parse(stTime);
            targetAppointment.EndTime = Int32.Parse(endTime);
            targetAppointment.ReminderType = ((ComboBoxItem)RemType.SelectedItem).Content.ToString();
            targetAppointment.ReminderTimeOfDay = ((ComboBoxItem)RemTOD.SelectedItem).Content.ToString();
            targetAppointment.ReminderDays = ((ComboBoxItem)RemDays.SelectedItem).Content.ToString();
            targetAppointment.Comments = CommentBox.Text;
            targetAppointment.Height = (type == "Consultation" ? "70" : "35");
            targetAppointment.Patient = activeAppt.Patient;
            targetAppointment.Opacity = activeAppt.Opacity;

            if (targetAppointment.Type == "Consultation")// && targetAppointment != activeAppt)
                apptThatFollowsTarget.Visibility = "Collapsed";
            else
                apptThatFollowsTarget.Visibility = "Visible";




            if (activeAppt.Type == "Consultation" && targetAppointment != activeAppt)
            {
                Appointment apptThatFollowsActive = DIVM.AVM.FindAppointmentThatFollows(activeAppt);
                apptThatFollowsActive.Visibility = "Visible";
            }

            if (targetAppointment != activeAppt)
            {
                activeAppt.Arrived = false;
                activeAppt.Height = "35";
                activeAppt.Opacity = "0";
                activeAppt.Type = "";
                activeAppt.Patient = "";
                activeAppt.Comments = "";
                activeAppt.EndTime = activeAppt.StartTime + 15;
                if (activeAppt.EndTime % 100 > 60)
                    activeAppt.EndTime += 40;

            }

            DIVM.AVM._activeAppointment = new Appointment(targetAppointment);

            Home h = App.Current.MainWindow as Home;
            h.SidebarView.SetSidebarView(new AppointmentDetailsSidebar());
        }

    }
}
