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

        public ModifyAppointmentSidebar()
        {
            InitializeComponent();

            //Workaround set, then set so if it is disabled it still collapses
            ReminderToggle.Checked += Reminder_Checked;
            ReminderToggle.Unchecked += Reminder_Unchecked;
            ReminderToggle.IsChecked = true;
            ReminderToggle.IsChecked = (App.Current.MainWindow.DataContext as DayInformationViewModel).AVM._activeAppointment.Reminder;


            this.Loaded += new RoutedEventHandler(ModifyAppointmentSidebar_Loaded);
        }


        void ModifyAppointmentSidebar_Loaded(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            DatePicker.InputText.TextField.Text = DIVM.AVM._activeAppointment.DateTimeStr;
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

        private void Reminder_Checked(object sender, RoutedEventArgs e)
        {
            RemDaysLable.Visibility = Visibility.Visible;
            RemTODLable.Visibility = Visibility.Visible;
            RemType.Visibility = Visibility.Visible;
            RemTypeLable.Visibility = Visibility.Visible;
            RemTOD.Visibility = Visibility.Visible;
            RemDays.Visibility = Visibility.Visible;
        }

        private void Reminder_Unchecked(object sender, RoutedEventArgs e)
        {
            RemDaysLable.Visibility = Visibility.Collapsed;
            RemTODLable.Visibility = Visibility.Collapsed;
            RemType.Visibility = Visibility.Collapsed;
            RemTypeLable.Visibility = Visibility.Collapsed;
            RemTOD.Visibility = Visibility.Collapsed;
            RemDays.Visibility = Visibility.Collapsed;
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
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToShortTimeString();
            }
            else
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToShortTimeString();
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
                if ((targetAppointment.Type != "") ||
                    (type == "Consultation" && apptThatFollowsTarget.Type != "" && apptThatFollowsTarget != activeAppt))
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

            DIVM._activeDate.HasChanged = false;


            targetAppointment.DoctorName = ((Doctor)DoctorComboBox.SelectedItem).DoctorName;
            targetAppointment.Type = type;
            targetAppointment.StartTime = Int32.Parse(stTime);
            targetAppointment.EndTime = Int32.Parse(endTime);
            targetAppointment.Reminder = ReminderToggle.IsChecked.Value;
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
