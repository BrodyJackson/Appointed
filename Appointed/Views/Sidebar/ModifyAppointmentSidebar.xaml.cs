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
        }


        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {

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



        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ApptTypeComboBox.SelectedItem as ComboBoxItem).Content as string) == "Standard")
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToShortTimeString();
            }
            else
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToShortTimeString();
            }
        }



        private void OnMouseLeftRelease_Save(object sender, MouseButtonEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            Appointment activeAppt = DIVM.AVM._appointmentLookup[Int32.Parse(DIVM.AVM._activeAppointment.ID)];
            Appointment targetAppointment = null;
            Appointment apptThatFollowsTarget = null;

            string stTime = ((Time)StartTime.SelectedItem).TimeString;
            stTime = stTime.Substring(0, stTime.IndexOf(':')) + stTime.Substring(stTime.IndexOf(':') + 1);

            string endTime = EndTime.Text;
            endTime = endTime.Substring(0, endTime.IndexOf(':')) + endTime.Substring(endTime.IndexOf(':') + 1, 2);

            string type = ApptTypeComboBox.SelectedValue.ToString();
            type = type.Substring(type.LastIndexOf(':') + 2);

            string drName = ((Doctor)DoctorComboBox.SelectedItem).DoctorName;
            string dateString = DatePicker.InputText.TextField.Text;

            // If Change of Date or Time, find the appointment slot they are trying to place it into.
            // Note that activeDate is changed when the user selects a date in the mini calendar popup.
            if (activeAppt.StartTimeStr != StartTime.Text || DIVM._activeDate.HasChanged || activeAppt.DoctorName != DoctorComboBox.Text)
            {
                // Build the key to look up the appointment slot they wish to book in.
                int time = Int32.Parse(stTime);
                int year = Int32.Parse(dateString.Substring(0, dateString.IndexOf('-')));

                int firstInd = dateString.IndexOf('-') + 1;
                int secondInd = dateString.LastIndexOf('-');
                int month = Int32.Parse(dateString.Substring(firstInd, secondInd - firstInd));

                int day = Int32.Parse(dateString.Substring(dateString.LastIndexOf('-') + 1));

                // The hashcode of the DateTime + <DrColumn> form the key for appointment lookups.
                DateTime dt = new DateTime(year, month, day, time / 100, time % 100, 0);
                int key = dt.GetHashCode() + DIVM.AVM.FindDrColumnForDrName(drName);

                targetAppointment = DIVM.AVM._appointmentLookup[key];
                if (targetAppointment != null)
                {
                    if (type == "Consultation")
                        apptThatFollowsTarget = DIVM.AVM.FindAppointmentThatFollows(targetAppointment);

                    if ( (targetAppointment.Type != "") || (type == "Consultation" && apptThatFollowsTarget.Type != ""))
                    {
                        // Show error popup notifying the user that the slot is taken
                        return;
                    }
                }

                DIVM._activeDate.HasChanged = false;
            }

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

            if (targetAppointment.Type == "Consultation")
                apptThatFollowsTarget.Visibility = "Collapsed";




            if (activeAppt.Type == "Consultation")
            {
                Appointment apptThatFollowsActive = DIVM.AVM.FindAppointmentThatFollows(activeAppt);
                apptThatFollowsActive.Visibility = "Visible";
            }

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


    }
}
