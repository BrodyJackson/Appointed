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

namespace Appointed.ViewModels
{


    public class DayInformationViewModel : ObservableObject, ISchedule
    {
        // Delegate -- Classes can subscribe their methods to this event to be called when event is raised. 
        public event EventHandler<EventArgs> ScheduleShifted;
        
        private DayInformationModel _dim;

        public AppointmentViewModel AVM { get; set; }

 
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



        public DayInformationViewModel()
        {
            _dim = new DayInformationModel();
            AVM = new AppointmentViewModel();

            _numAppointmentsPerDay = AVM._numAppointmentsPerDay;

        
            _timeOfDayStringsTwelveHour = new ObservableCollection<Time>();
            _timeOfDayStringsTwentyFourHour = new ObservableCollection<Time>();
            _dayCodes = _dim.DayCodes;

            InitDayInformation();
        
            InitTimeOfDayStrings();

            return;
        }






        // COMMANDS ====================================================
        private void ChangeDaysInScope(int amount)
        {
            _dim.ShiftDay(amount);
            _dayCodes = _dim.DayCodes;

            InitDayInformation();


            if (ScheduleShifted != null)
                ScheduleShifted(this, new EventArgs());
        }

        public ShiftScheduleViewCommand ShiftView
        {
            get { return new ShiftScheduleViewCommand(ChangeDaysInScope); }
        }


        // END COMMANDS ====================================================






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
