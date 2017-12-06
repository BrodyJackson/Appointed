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
using Appointed.Views.Sidebar.Widgets;

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

            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;

            //Hide/Show the options
            ReminderToggle.Checked += Reminder_Checked;
            ReminderToggle.Unchecked += Reminder_Unchecked;
            AddToWaitlistCheckBox.Checked += AddToWaitlistCheckBox_Checked;
            AddToWaitlistCheckBox.Unchecked += AddToWaitlistCheckBox_Unchecked;

            ReminderToggle.IsChecked = true;
            AddToWaitlistCheckBox.IsChecked = true;

            this.Loaded += new RoutedEventHandler(ModifyAppointmentSidebar_Loaded);

            CommentBox.GotFocus += (s, e) => { App.AllowArrowKeyCalendarNavigation = false; };
            CommentBox.LostFocus += (s, e) => { App.AllowArrowKeyCalendarNavigation = true; };

            DatePicker.OnCalendarLoaded += DatePicker_OnCalendarLoaded;
            WaitlistDatePicker.OnCalendarLoaded += DatePicker_OnCalendarLoaded;

            DatePicker.OnDateChosen += DatePicker_OnDateChosen;

            ThreeDayView tdv = (App.Current.MainWindow as Home).ThreeDayView;

            tdv.DayOne.DrColumn0.OnEmptyApptClick += EmptySlotClick;
            tdv.DayOne.DrColumn1.OnEmptyApptClick += EmptySlotClick;
            tdv.DayOne.DrColumn2.OnEmptyApptClick += EmptySlotClick;

            tdv.DayTwo.DrColumn0.OnEmptyApptClick += EmptySlotClick;
            tdv.DayTwo.DrColumn1.OnEmptyApptClick += EmptySlotClick;
            tdv.DayTwo.DrColumn2.OnEmptyApptClick += EmptySlotClick;

            tdv.DayThree.DrColumn0.OnEmptyApptClick += EmptySlotClick;
            tdv.DayThree.DrColumn1.OnEmptyApptClick += EmptySlotClick;
            tdv.DayThree.DrColumn2.OnEmptyApptClick += EmptySlotClick;
        }


        private void Reminder_Checked(object sender, RoutedEventArgs e)
        {
            RemDaysLable.Visibility = Visibility.Visible;
            RemTODLable.Visibility = Visibility.Visible;
            RemType.Visibility = Visibility.Visible;

            DayInformationViewModel DIVM = (App.Current.MainWindow.DataContext as DayInformationViewModel);
            if (DIVM.AVM._activeAppointment.PatientObj != null)
            {//Only show type for which individual has contact method
                ComboBoxItem[] items = new ComboBoxItem[3];
                RemType.Items.CopyTo(items, 0);

                //Remove Text option
                if (string.IsNullOrWhiteSpace(DIVM.AVM._activeAppointment.PatientObj.Cell))
                {
                    RemType.Items.Remove(items[1]);
                }
                //Remove Phone
                if (string.IsNullOrWhiteSpace(DIVM.AVM._activeAppointment.PatientObj.Phone) && string.IsNullOrWhiteSpace(DIVM.AVM._activeAppointment.PatientObj.Business) && string.IsNullOrWhiteSpace(DIVM.AVM._activeAppointment.PatientObj.Cell))
                {
                    RemType.Items.Remove(items[2]);
                }
                //Remove Email
                if (string.IsNullOrWhiteSpace(DIVM.AVM._activeAppointment.PatientObj.Email))
                {
                    RemType.Items.Remove(items[0]);
                }
            }
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



        void ModifyAppointmentSidebar_Loaded(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
            DatePicker.InputText.TextField.Text = DIVM.AVM._activeAppointment.DateTime.Value.ToString("yyyy-MM-dd");
            PatientName.Text = DIVM.AVM._activeAppointment.Patient;
            CurrentApptType.Text = DIVM.AVM._activeAppointment.Type;
            CurrentApptDoc.Text = DIVM.AVM._activeAppointment.DoctorName;
            CurrentApptTimespan.Text = DIVM.AVM._activeAppointment.StartTimeStr + " - " + DIVM.AVM._activeAppointment.EndTimeStr;
            ReminderToggle.IsChecked = DIVM.AVM._activeAppointment.Reminder;
            RemDays.SelectedIndex = DIVM.AVM._activeAppointment.RemDaysIndex;
            RemTOD.SelectedIndex = DIVM.AVM._activeAppointment.RemTODIndex;
            RemType.SelectedIndex = DIVM.AVM._activeAppointment.RemTypeIndex;
            AddToWaitlistCheckBox.IsChecked = DIVM.AVM._activeAppointment.Waitlisted;
            WaitlistDatePicker.InputText.TextField.Text = DIVM.WaitList.GetApptWaiting(DIVM.AVM._activeAppointment).DateTime.Value.ToString("yyyy-MM-dd");
            WaitlistDoctorComboBox.SelectedIndex = DIVM.WaitList.GetApptWaiting(DIVM.AVM._activeAppointment).DrColumn;
            WaitlistStartTime.SelectedIndex = DIVM.WaitList.GetApptWaiting(DIVM.AVM._activeAppointment).TimeIndex;

            StartTime.SelectionChanged += StartTime_SelectionChanged;
            DoctorComboBox.SelectionChanged += DIVM.ChangeHighlight;
            ApptTypeComboBox.SelectionChanged += DIVM.ChangeHighlight;

            //ActiveDateChanged(null, null);
        }

        private void EmptySlotClick(object sender, DoctorColumnView.ApptClickEventArgs e)
        {
            DatePicker.InputText.TextField.Text = e.Date.ToString("yyyy-MM-dd");

            StartTime.SelectedIndex = (App.Current.MainWindow.DataContext as DayInformationViewModel).TimeStamps.ToList().FindIndex(t => t.TimeString == e.Date.ToString("H:mm"));
        }

        private void DatePicker_OnCalendarLoaded(object sender, EventArgs e)
        {
            Calendar calendar = sender as Calendar;
            AppointmentViewModel AVM = (App.Current.MainWindow.DataContext as DayInformationViewModel).AVM;

            calendar.BlackoutDates.AddDatesInPast();
            calendar.BlackoutDates.Add(new CalendarDateRange(AVM.BeginningOfAllTime.AddDays(AVM.NumOfDaysPopulated), DateTime.MaxValue));
        }

        private void AddToWaitlistCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            WaitlistDocLabel.Visibility = Visibility.Collapsed;
            WaitlistDoctorComboBox.Visibility = Visibility.Collapsed;
            WaitlistDateLabel.Visibility = Visibility.Collapsed;
            WaitlistDatePicker.Visibility = Visibility.Collapsed;
            WaitlistEndTimeLabel.Visibility = Visibility.Collapsed;
            WaitlistEndTime.Visibility = Visibility.Collapsed;
            WaitlistStartTimeLabel.Visibility = Visibility.Collapsed;
            WaitlistStartTime.Visibility = Visibility.Collapsed;
        }

        private void AddToWaitlistCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            WaitlistDocLabel.Visibility = Visibility.Visible;
            WaitlistDoctorComboBox.Visibility = Visibility.Visible;
            WaitlistDateLabel.Visibility = Visibility.Visible;
            WaitlistDatePicker.Visibility = Visibility.Visible;
            WaitlistEndTimeLabel.Visibility = Visibility.Visible;
            WaitlistEndTime.Visibility = Visibility.Visible;
            WaitlistStartTimeLabel.Visibility = Visibility.Visible;
            WaitlistStartTime.Visibility = Visibility.Visible;
        }

        private void DatePicker_OnDateChosen(object sender, Controls.DateSelectedEventArgs e)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;

            //Shift calendar view to focus on this appointment
            DateTime activeDT = new DateTime(DIVM._activeDate.Year, DIVM._activeDate.Month, DIVM._activeDate.Day);
            TimeSpan diff = e.Date - activeDT;

            int shiftAmt = diff.Days;

            if (Math.Abs(diff.Days) > 0)
            {
                DateTime dt;
                if (DateTime.TryParse(DatePicker.InputText.TextField.Text, out dt))
                {
                    string stTime = ((Time)StartTime.SelectedItem).TimeString;
                    stTime = stTime.Substring(0, stTime.IndexOf(':')) + stTime.Substring(stTime.IndexOf(':') + 1);
                    int time = Int32.Parse(stTime);
                    dt = new DateTime(dt.Year, dt.Month, dt.Day, time / 100, time % 100, 0);
                    DIVM._activeDate.SetDateAndTime(dt);
                }
            }

            DIVM.ChangeHighlight(this, null);
        }


        void StartTime_SelectionChanged(object sender, EventArgs e)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;
            DateTime dt;

            if (DateTime.TryParse(DIVM._activeDate.DateTimeStr, out dt) && StartTime.SelectedItem != null)
            {
                string stTime = ((Time)StartTime.SelectedItem).TimeString;
                stTime = stTime.Substring(0, stTime.IndexOf(':')) + stTime.Substring(stTime.IndexOf(':') + 1);
                int time = Int32.Parse(stTime);
                dt = new DateTime(dt.Year, dt.Month, dt.Day, time / 100, time % 100, 0);
                DIVM._activeDate.SetDateAndTime(dt);
            }

            DIVM.ChangeHighlight(this, null);
        }

        // Decision confirmation logic
        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {
            MyMessageBox msgBox = new MyMessageBox();

            msgBox.MessageBoxResult += OnDiscardConfirmation;

            msgBox.Show
                (
                    "Are you sure you wish to discard your changes?",
                    "Confirm Selection",
                    MyMessageBox.Buton.Yes,
                    MyMessageBox.Buton.No
                );
        }
        private void OnDiscardConfirmation(object sender, MessageBoxEventArgs e)
        {
            MyMessageBox.Result r = e.result;

            if (r == MyMessageBox.Result.Yes)
            {
                Home h = App.Current.MainWindow as Home;
                h.SidebarView.SetSidebarView(h.SidebarView.GetPreviousSidebar());
            }
        }


        private void ComboBox_StartTimeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StartTime.SelectedItem == null || ApptTypeComboBox.SelectedItem == null)
            {
                return;
            }

            if (((ApptTypeComboBox.SelectedItem as ComboBoxItem).Content as string) == "Standard")
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToString("HH:mm").TrimStart('0');
            }
            else
            {
                EndTime.Text = DateTime.Parse((StartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToString("HH:mm").TrimStart('0');
            }
        }


        private void ComboBox_ApptTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox_StartTimeSelectionChanged(null, null);
        }

        private void ComboBox_WaitlistTimeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WaitlistStartTime.SelectedItem == null || ApptTypeComboBox.SelectedItem == null)
            {
                return;
            }
            if (((ApptTypeComboBox.SelectedItem as ComboBoxItem).Content as string) == "Standard")
            {
                WaitlistEndTime.Text = DateTime.Parse((WaitlistStartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToString("HH:mm").TrimStart('0');
            }
            else
            {
                WaitlistEndTime.Text = DateTime.Parse((WaitlistStartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToString("HH:mm").TrimStart('0');
            }
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
                    MyMessageBox msgBox = new MyMessageBox();
                    msgBox.Show
                        (
                            "The time slot specified is taken!",
                            "Unable to Modify Appointment",
                            MyMessageBox.Buton.Ok
                        );

                    return;
                }

                int sTime = Int32.Parse(stTime); int eTime = Int32.Parse(endTime); if (eTime < sTime) eTime += 1200;

                if ((!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(sTime)) ||
                        (!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(eTime)))
                {
                    MyMessageBox msgBox = new MyMessageBox();
                    msgBox.Show
                        (
                            "The doctor specified is unavailable at that time!", //TODO More specific error message
                            "Unable to Modify Appointment",
                            MyMessageBox.Buton.Ok
                        );

                    return;
                }
            }


            DIVM.ResetHighlightedAppointment();
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
            targetAppointment.PatientObj = activeAppt.PatientObj;

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
