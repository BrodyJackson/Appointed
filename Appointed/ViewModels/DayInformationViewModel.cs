using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Appointed.Events;
using Appointed.Models;
using Appointed.Commands;
using Appointed.Classes;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using Appointed.Views.Sidebar;

namespace Appointed.ViewModels
{


    public class DayInformationViewModel : ObservableObject, ISchedule
    {
        // Raised when an appointment holding up a waitlist is removed.
        // Classes can subscribe their methods to this to be called when the event is raised. 
        public event EventHandler<WaitlistEventArgs> WaitlistAlert;


        // Raised when the days in scope in the three day view are changed.
        // Classes can subscribe their methods to this to be called when the event is raised. 
        public event EventHandler<EventArgs> ScheduleShifted;
        
        /// <summary>
        /// Invoked whenever a filter option is changed.
        /// When all or no doctors is clicked, this event will fire for each of the filter options that have changed.
        /// </summary>
        public event EventHandler<EventArgs> DoctorFilterChangedDIVM;
        /// <summary>
        /// Invoked whenever a filter option is changed.
        /// When all or no appts is clicked, this event will fire for each of the filter options that have changed.
        /// </summary>
        public event EventHandler<EventArgs> ApptFilterChangedDIVM;


        private DayInformationModel _dim;

        public AppointmentViewModel AVM { get; set; }
       
        public PatientViewModel PVM { get; set; }

        public SidebarViewModel SVM { get; set; }


        public Waitlist WaitList { get; set; }
 
        private ObservableCollection<Time> _timeOfDayStringsTwelveHour;
        private ObservableCollection<Time> _timeOfDayStringsTwentyFourHour;
        public  List<int> _dayCodes;


        private string _firstDay;
        private string _secondDay;
        private string _thirdDay;

        private int _numAppointmentsPerDay;

        private string _month;
        private string _year;
        private string _day;


        public Date _activeDate { get; set; }


        public DayInformationViewModel()
        {
            WaitList = new Waitlist();

            _activeDate = new Date();



            _dim = new DayInformationModel();
            AVM = new AppointmentViewModel();
            PVM = new PatientViewModel();
            SVM = new SidebarViewModel();

            _numAppointmentsPerDay = AVM._numAppointmentsPerDay;

        
            _timeOfDayStringsTwelveHour = new ObservableCollection<Time>();
            _timeOfDayStringsTwentyFourHour = new ObservableCollection<Time>();
            _dayCodes = _dim.DayCodes;

            InitDayInformation();
        
            InitTimeOfDayStrings();

            _activeDate.Year = _dim.YearAsInt;
            _activeDate.Month = _dim.MonthAsInt;
            _activeDate.Day = _dim.DayAsInt;
            _activeDate.Time24Hr = 900;


            AVM.AppointmentMoved += OnAppointmentMoved;
            return;
        }


        public DateTime GetDateTime()
        {
            return new DateTime(_dim.YearAsInt, _dim.MonthAsInt, _dim.DayAsInt);
        }

        public T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            if (parentObject == null) return null;

            T parent = parentObject as T;

            if (parent != null)
                return parent;
            else
                return FindParent<T>(parentObject);
        }

        public T GetSidebar<T>(Home h) where T : UserControl
        {
            var children = h.SidebarView.SidebarGridLayout.Children.OfType<T>();

            if (children.Count() == 0)
                return null;

            return children.ElementAt(0);
        }

        // COMMANDS ====================================================
        private void ChangeDaysInScope(int amount)
        {
            _dim.ShiftDay(amount);
            _dayCodes = _dim.DayCodes;

            InitDayInformation();

            _activeDate.Year = _dim.YearAsInt;
            _activeDate.Month = _dim.MonthAsInt;
            _activeDate.Day = _dim.DayAsInt;

            if (ScheduleShifted != null)
                ScheduleShifted(this, new EventArgs());
        }

        public ShiftScheduleViewCommand ShiftView
        {
            get { return new ShiftScheduleViewCommand(ChangeDaysInScope); }
        }


        public void changeDoctorFilterSelection()
        {
            if (DoctorFilterChangedDIVM != null)
                DoctorFilterChangedDIVM(this, new EventArgs());
        }

        public void changeAppointmentFilterSelection()
        {
            if (ApptFilterChangedDIVM != null)
                ApptFilterChangedDIVM(this, new EventArgs());
        }

        public void FreeAppointmentSlot(Appointment appt)
        {
            Appointment a = WaitList.GetApptWaiting(appt);

            if (a == null || a == appt)
                return;

            if (WaitlistAlert != null)
                WaitlistAlert
                (
                    appt,
                    new WaitlistEventArgs
                    {
                        DoctorName = appt.DoctorName,
                        Date = new Date
                        {
                            Day = appt.DateTime.Value.Day,
                            Month = appt.DateTime.Value.Month,
                            Year = appt.DateTime.Value.Year,
                            Time24Hr = appt.StartTime
                        },

                        Key = Int32.Parse(a.ID)
                    }
                );
        }

        public void UpdateSchedule()
        {
            if (ScheduleShifted != null)
                ScheduleShifted(this, new EventArgs());
        }

        private void OnAppointmentMoved(object sender, WaitlistEventArgs e)
        {
            Appointment a = sender as Appointment;

            ShiftView.Execute(1);
            ShiftView.Execute(-1);

            FreeAppointmentSlot(a);
        }

        // END COMMANDS ====================================================


        public void ChangeHighlight(object sender, EventArgs e)
        {
            ResetHighlightedAppointment();

            Home h = App.Current.MainWindow as Home;
            NewAppointmentSidebar n;
            ModifyAppointmentSidebar m;

            DateTime dt;

            int year;
            int month;
            int day;
            int stTime;

            string drName;
            string apptType;

            n = GetSidebar<NewAppointmentSidebar>(h);
            m = GetSidebar<ModifyAppointmentSidebar>(h);
            if (n != null)
            {
                drName = ((Doctor)(n.DoctorComboBox).SelectedItem).DoctorName;
                apptType = n.ApptTypeComboBox.SelectedValue.ToString();
                apptType = apptType.Substring(apptType.LastIndexOf(':') + 2);
                stTime = _activeDate.Time24Hr;

                year = _activeDate.Year;
                month = _activeDate.Month;
                day = _activeDate.Day;

                dt = new DateTime(year, month, day, stTime / 100, stTime % 100, 0);

                HighlightAppointment(dt, drName, apptType);
            }
            else if (m != null)
            {
                drName = ((Doctor)(m.DoctorComboBox).SelectedItem).DoctorName;
                apptType = m.ApptTypeComboBox.SelectedValue.ToString();
                apptType = apptType.Substring(apptType.LastIndexOf(':') + 2);
                stTime = _activeDate.Time24Hr;

                year = _activeDate.Year;
                month = _activeDate.Month;
                day = _activeDate.Day;


                dt = new DateTime(year, month, day, stTime / 100, stTime % 100, 0);

                HighlightAppointment(dt, drName, apptType);
            }
        }
                

        private void HighlightAppointment(DateTime dt, string drName, string apptType)
        {
            int drColumn = AVM.FindDrColumnForDrName(drName);
            int key = dt.GetHashCode() + drColumn;

            if (!AVM._appointmentLookup.ContainsKey(key))
                return;

            Appointment a = AVM._appointmentLookup[key];

            if (a.Type != "" || a.Colour == "SlateGray")
                return;

            Appointment apptThatFollows;
            if (apptType == "Consultation")
            {
                apptThatFollows = AVM.FindAppointmentThatFollows(a);

                if (apptThatFollows.Type == "")
                    apptThatFollows.Visibility = "Collapsed";
                else
                    return;

                a.Height = "70";
            }

            a.BorderColour = "BlueViolet";
            a.Opacity = "0.7";
            a.StrokeThickness = "2";
            a.Colour = "DodgerBlue";

            AVM._highlightedAppointment = a;

            //DateTime dimDT = new DateTime(_dim.YearAsInt, _dim.MonthAsInt, _dim.DayAsInt, dt.Hour, dt.Minute, 0);
            //DateTime centerDT = dimDT.AddDays(1);

            //TimeSpan diff = dt - centerDT;

            //if (diff.Days > 1 || diff.Days < -1)
            //    ShiftView.Execute(diff.Days);
        }
        

        public void ResetHighlightedAppointment()
        {
            if (AVM._highlightedAppointment == null)
                return;

            Appointment a;

            if (AVM._highlightedAppointment.Height == "70")
            {
                a = AVM.FindAppointmentThatFollows(AVM._highlightedAppointment);
                a.Visibility = "Visible";

                AVM._highlightedAppointment.Height = "35";
            }

            string colour = AVM.FindDrColourForDrName(AVM._highlightedAppointment.DoctorName);

            AVM._highlightedAppointment.BorderColour = colour;
            AVM._highlightedAppointment.Opacity = "0";
            AVM._highlightedAppointment.StrokeThickness = "1";
            AVM._highlightedAppointment.Colour = colour;

            AVM._highlightedAppointment = new Appointment(AVM.SpecterEmpty.ElementAt(0));
        }









        public string GetMonthString(int month)
        {
            return (_dim.GetMonthString(month));
        }


        public string GetDayString(int day)
        {
            return (_dim.GetDayString(day));
        }


  
        // PROPERTIES ====================================================

        public List<string> DaysInScope
        {
            get { return _dim.DaysInScope; }
        }

        public string FirstDay
        {
            get { return _firstDay; }
            set
            {
                _firstDay = value;
                RaisePropertyChangedEvent("FirstDay");
            }
        }

        public string SecondDay
        {
            get { return _secondDay; }
            set
            {
                _secondDay = value;
                RaisePropertyChangedEvent("SecondDay");
            }
        }
        public string ThirdDay
        {
            get { return _thirdDay; }
            set
            {
                _thirdDay = value;
                RaisePropertyChangedEvent("ThirdDay");
            }

        }
        public string MonthAndYear
        {
            get { return Month + " " + Year; }
        }
    



        public int DayAsInt { get { return _dim.DayAsInt; } }

        public int MonthAsInt { get { return _dim.MonthAsInt; } }

        public int YearAsInt { get { return _dim.YearAsInt; } }

        


        public ObservableCollection<Time> TimeStamps
        {
            get { return _timeOfDayStringsTwelveHour; }
            set
            {
                _timeOfDayStringsTwelveHour = new ObservableCollection<Time>(value);
                RaisePropertyChangedEvent("TimeStamps");
            }
        }


        public string Year
        {
            get { return _year; }
            set
            {
                _year = value;
                RaisePropertyChangedEvent("Year");
            }

        }
        public string Month
        {
            get { return _month; }
            set
            {
                _month = value;
                RaisePropertyChangedEvent("Month");
            }
        }
        public string Day
        {
            get { return _day; }
            set
            {
                _day = value;
                RaisePropertyChangedEvent("Day");
            }
        }


        // END PROPERTIES ====================================================




        // FUNCTIONS ====================================================

        private void InitDayInformation()
        {
            Console.WriteLine("\n\nInit Days.\n\n");

            Month = _dim.Month;
            Year = _dim.Year;
            Day = _dim.Day;


            FirstDay = _dim.DaysInScope.ElementAt(0);
            SecondDay = _dim.DaysInScope.ElementAt(1);
            ThirdDay = _dim.DaysInScope.ElementAt(2);

        }


        public void InitTimeOfDayStrings()
        {
            int time = 700;
            string timeString = "";

            for (int i = 0; i < _numAppointmentsPerDay; i++)
            {
                int length = time.ToString().Length;
                int timeTwelveHour;

                timeString = time.ToString().Substring(0, length - 2) + ':' + time.ToString().Substring(length - 2);
                _timeOfDayStringsTwelveHour.Add(new Time() { TimeString = timeString });


                if (time >= 1300)
                {
                    timeTwelveHour = time - 1200;

                    length = timeTwelveHour.ToString().Length;
                    timeString = timeTwelveHour.ToString().Substring(0, length - 2) + ':' + timeTwelveHour.ToString().Substring(length - 2);
                    _timeOfDayStringsTwentyFourHour.Add(new Time() { TimeString = timeString });
                }


                if (time % 100 == 45)
                    time += 55;
                else
                    time += 15;
            }

        }



        // END FUNCTIONS ====================================================


    }









}
