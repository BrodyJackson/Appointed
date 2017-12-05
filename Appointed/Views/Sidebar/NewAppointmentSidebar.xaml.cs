
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Appointed.Classes;
using Appointed.ViewModels;
using Appointed.Views.Sidebar.Widgets;

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

            //Hide/Show the options
            ReminderToggle.Checked += ReminderToggle_Checked;
            ReminderToggle.Unchecked += ReminderToggle_Unchecked;
            AddToWaitlistCheckBox.Checked += AddToWaitlistCheckBox_Checked;
            AddToWaitlistCheckBox.Unchecked += AddToWaitlistCheckBox_Unchecked;
            //Set default values
            ReminderToggle.IsChecked = true;
            // Workaround to toggle/untoggle so its actually hidden... 
            AddToWaitlistCheckBox.IsChecked = true;
            AddToWaitlistCheckBox.IsChecked = false;

            //Black out dates which are in the past, or beyond what we have doctor availablity for
            DatePicker.OnCalendarLoaded += DatePicker_OnCalendarLoaded;
            WaitlistDatePicker.OnCalendarLoaded += DatePicker_OnCalendarLoaded;

            DatePicker.OnDateChosen += DatePicker_OnDateChosen;

            CommentBox.GotFocus += (s, e) => { App.AllowArrowKeyCalendarNavigation = false; };
            CommentBox.LostFocus += (s, e) => { App.AllowArrowKeyCalendarNavigation = true; };

            this.Loaded += NewAppointmentSidebar_Loaded;
         }



        void NewAppointmentSidebar_Loaded(object sender, RoutedEventArgs e)
        {
            DayInformationViewModel DIVM = this.DataContext as DayInformationViewModel;
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

            StartTime.SelectionChanged += DIVM.ChangeHighlight;
            DoctorComboBox.SelectionChanged += DIVM.ChangeHighlight;
            ApptTypeComboBox.SelectionChanged += DIVM.ChangeHighlight;

        }

        private void EmptySlotClick(object sender, DoctorColumnView.ApptClickEventArgs e)
        {
            DatePicker.InputText.TextField.Text = e.Date.ToString("yyyy-MM-dd");

            StartTime.SelectedIndex = (App.Current.MainWindow.DataContext as DayInformationViewModel).TimeStamps.ToList().FindIndex(t => t.TimeString == e.Date.ToString("H:mm"));
        }

        private void DatePicker_OnDateChosen(object sender, Controls.DateSelectedEventArgs e)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;

            //Shift calendar view to focus on this appointment
            DateTime activeDT = new DateTime(DIVM._activeDate.Year, DIVM._activeDate.Month, DIVM._activeDate.Day);
            TimeSpan diff = e.Date - activeDT;

            int shiftAmt = diff.Days;

            if (e.ShouldShiftView)
            {
                shiftAmt -= 1;

                DatePicker.InputText.TextField.Text = DIVM._activeDate.DateTimeStr;
                WaitlistDatePicker.InputText.TextField.Text = DIVM._activeDate.DateTimeStr;

                if (DIVM.ShiftView.CanExecute(null))
                    DIVM.ShiftView.Execute(shiftAmt);
            }
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

        private void ReminderToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            RemTypeLable.Visibility = Visibility.Collapsed;
            RemType.Visibility = Visibility.Collapsed;
            RemTODLable.Visibility = Visibility.Collapsed;
            RemTOD.Visibility = Visibility.Collapsed;
            RemDaysLable.Visibility = Visibility.Collapsed;
            RemDays.Visibility = Visibility.Collapsed;

        }

        private void ReminderToggle_Checked(object sender, RoutedEventArgs e)
        {
            RemTypeLable.Visibility = Visibility.Visible;
            RemType.Visibility = Visibility.Visible;
            RemTODLable.Visibility = Visibility.Visible;
            RemTOD.Visibility = Visibility.Visible;
            RemDaysLable.Visibility = Visibility.Visible;
            RemDays.Visibility = Visibility.Visible;
        }

        //void NewAppointmentSidebar_Loaded(object sender, RoutedEventArgs e)
        //{
        //    ApptTypeComboBox.SelectionChanged += ComboBox_ApptTypeSelectionChanged;

        //    //Clear selected index so its not equal to whatever the last active appt was set to
        //    StartTime.SelectedIndex = -1;
        //    EndTime.Text = String.Empty;
        //}

        private void OnMouseLeftRelease_Discard(object sender, MouseButtonEventArgs e)
        {
            MyMessageBox msgBox = new MyMessageBox();

            msgBox.MessageBoxResult += OnDiscardConfirmation;

            msgBox.Show
                (
                    "Are you sure you wish to discard your changes?",
                    "Discard Appointment Booking",
                    MyMessageBox.Buton.Yes,
                    MyMessageBox.Buton.No
                );
        }
        // Decision confirmation logic
        private void OnDiscardConfirmation(object sender, MessageBoxEventArgs e)
        {
            MyMessageBox.Result r = e.result;

            if (r == MyMessageBox.Result.Yes)
            {
                Home h = App.Current.MainWindow as Home;
                h.SidebarView.SetSidebarView(h.SidebarView.GetPreviousSidebar(), false);
            }
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
                WaitlistEndTime.Text = DateTime.Parse((WaitlistStartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(15).ToString("HH:mm").TrimStart('0');
            }
            else
            {
                WaitlistEndTime.Text = DateTime.Parse((WaitlistStartTime.SelectedItem as Classes.Time).TimeString).AddMinutes(30).ToString("HH:mm").TrimStart('0');
            }
        }

        private void ComboBox_TimeSelectionChanged(object sender, SelectionChangedEventArgs e)
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
            DateTime dt = GetDateTime(time, dateString);
            int drColumn = DIVM.AVM.FindDrColumnForDrName(drName);
            int key = dt.GetHashCode() + drColumn;

            targetAppointment = DIVM.AVM._appointmentLookup[key];
            if (targetAppointment != null)
            {
                if (type == "Consultation")
                    apptThatFollowsTarget = DIVM.AVM.FindAppointmentThatFollows(targetAppointment);

                if ((targetAppointment.Type != "") || (type == "Consultation" && apptThatFollowsTarget.Type != ""))
                {
                    MyMessageBox msgBox = new MyMessageBox();
                    msgBox.Show
                        (
                            "The time slot: " + (StartTime.SelectedItem as Time).TimeString + " - " + EndTime.Text + " is not free.",
                            "Unable to Schedule Appointment",
                            MyMessageBox.Buton.Ok
                        );
                    return;
                }

                if ((!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(Int32.Parse(stTime))) ||
                        (!DIVM.AVM.DoctorsOnShift.ElementAt(drColumn).IsAvailable(Int32.Parse(endTime))))
                {
                    MyMessageBox msgBox = new MyMessageBox();
                    msgBox.Show
                        (
                            drName + " is Unavaliable " + dateString + " at " + (StartTime.SelectedItem as Time).TimeString,
                            "Unable to Schedule Appointment",
                            MyMessageBox.Buton.Ok
                        );
                    return;
                }


            }

            DIVM.ResetHighlightedAppointment();

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

                DateTime date = GetDateTime(time, dateString);

                drName = ((Doctor)WaitlistDoctorComboBox.SelectedItem).DoctorName;

                _newAppointment.WaitlistPos = DIVM.WaitList.AddAppointment(_newAppointment, date, drName).ToString();
                _newAppointment.Waitlisted = true;
            }

            _newAppointment.Type = type;
            _newAppointment.StartTime = Int32.Parse(stTime);
            _newAppointment.EndTime = Int32.Parse(endTime);
            _newAppointment.Reminder = ReminderToggle.IsChecked.Value;
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

            _newAppointment.PatientObj = DIVM.PVM.ActivePatient;
            DIVM.PVM.ActivePatient.AddUpcommingAppointment(key);
            DIVM.AVM._activeAppointment = new Appointment(_newAppointment);

            Home h = App.Current.MainWindow as Home;
            h.SidebarView.SetSidebarView(new AppointmentDetailsSidebar(), false);

            //Shift calendar view to focus on this appointment
            DateTime activeDT = new DateTime(DIVM._activeDate.Year, DIVM._activeDate.Month, DIVM._activeDate.Day);
            TimeSpan diff = _newAppointment.DateTime.Value - activeDT;

            if (DIVM.ShiftView.CanExecute(null))
                DIVM.ShiftView.Execute(diff.Days);
        }


        public DateTime GetDateTime(int startTime, string yearMonthDay)
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
