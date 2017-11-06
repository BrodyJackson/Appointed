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
            Appointment appt = DIVM.AVM._appointmentLookup[Int32.Parse(DIVM.AVM._activeAppointment.ID)];


            // If Change of Date or Time, find the appointment slot they are trying to place it into.
            if (appt.StartTimeStr != StartTime.Text || DIVM._activeDate.HasChanged)
            {
                string stTime = StartTime.Text;
                stTime = stTime.Substring(0, stTime.IndexOf(':')) + stTime.Substring(stTime.IndexOf(':') + 1);
                int time = Int32.Parse(stTime);

                string dateString = DatePicker.InputText.TextField.Text;
                int year = Int32.Parse(dateString.Substring(0, dateString.IndexOf('-')));
                int month = Int32.Parse(dateString.Substring(dateString.IndexOf('-') + 1, dateString.LastIndexOf('-')));
                int day = Int32.Parse(dateString.Substring(dateString.LastIndexOf('-') + 1));

                // The hashcode of the DateTime + the doctor column form the key for appointment lookups
                DateTime dt = new DateTime(year, month, day, time / 100, time % 100, 0);

                int key = dt.GetHashCode() + DIVM.AVM.FindDrColumnForDrName(appt.DoctorName);

                if (DIVM.AVM._appointmentLookup[key] != null)
                {
                    // Check that appointment slot is free and if the source is a consultation, check that the following slot is free as well.
                }

                DIVM._activeDate.HasChanged = false;
            }


            appt.DoctorName = DoctorComboBox.Text;
            appt.Type = ApptTypeComboBox.SelectedValue.ToString();

            string startTime = StartTime.Text;
            startTime = startTime.Substring(0, startTime.IndexOf(':')) + startTime.Substring(startTime.IndexOf(':') + 1);
            appt.StartTime = Int32.Parse(startTime);

            string endTime = EndTime.Text;
            endTime = endTime.Substring(0, endTime.IndexOf(':')) + endTime.Substring(endTime.IndexOf(':') + 1);
            appt.EndTime = Int32.Parse(endTime);

            appt.ReminderType = RemType.Text;
            appt.ReminderTimeOfDay = RemTOD.Text;
            appt.ReminderDays = RemDays.Text;
            appt.Comments = CommentBox.Text;


            //DoctorComboBox
            //ApptTypeComboBox
            //DatePicker
            //StartTime
            //EndTime
            //RemType
            //RemDays
            //RemTOD
            //CommentBox

        }
    }
}
