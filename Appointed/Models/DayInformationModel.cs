using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Appointed.Models
{

    public class DayInformationModel
    {
        private static System.Globalization.Calendar _myCal
                                = CultureInfo.InvariantCulture.Calendar;

        private int _numDaysBeingDisplayed;
        private int _dayToStartNumberingFrom;
        private int _numberOfDaysInMonth;
        private List<String> _daysToDisplayForMonth;
        private int _year;
        private int _month;
        private int _day;
        private int _rowsNeeded;
        private string _monthString;
        private string _yearStringNumeric;
        private string _dayStringNumeric;
        private List<string> _daysInScope;
        private List<int> _dayCodes;

        public DayInformationModel()
        {
            _year = _myCal.GetYear(DateTime.Today);
            _month = _myCal.GetMonth(DateTime.Today);
            _day = _myCal.GetDayOfMonth(DateTime.Today);

            _numDaysBeingDisplayed = 3;

            InitModel();
        }

        public DayInformationModel(int year, int month, int day)
        {
            _month = month;
            _year = year;
            _day = day;

            InitModel();
        }


        public void InitModel()
        {
            GetNumberOfDaysInMonth();
            GetDayOfWeekForFirstDayOfMonth();
            GetDayNumberingSequence();
            GetMonthString();
            FindRowCount(_month, _year);

            _yearStringNumeric = _year.ToString();
            _dayStringNumeric = _day.ToString();


            SetDaysInScope();
        }


        public List<string> DaysToDisplayForMonth
        {
            get { return _daysToDisplayForMonth; }
        }
        public string Day
        {
            get { return _dayStringNumeric; }
        }
        public string Month
        {
            get { return _monthString; }
        }
        public string Year
        {
            get { return _yearStringNumeric; }
        }


        public int RowCount
        {
            get { return _rowsNeeded; }
        }


        public List<string> DaysInScope
        {
            get { return _daysInScope; }
        }


        public List<int> DayCodes
        {
            get { return _dayCodes; }
        }



        public int DayAsInt { get { return _day; } }
        public int MonthAsInt { get { return _month; } }
        public int YearAsInt { get { return _year; } }


        private void GetMonthString()
        {
            switch (_month)
            {
                case 1:
                    _monthString = "January";
                    break;
                case 2:
                    _monthString = "February";
                    break;
                case 3:
                    _monthString = "March";
                    break;
                case 4:
                    _monthString = "April";
                    break;
                case 5:
                    _monthString = "May";
                    break;
                case 6:
                    _monthString = "June";
                    break;
                case 7:
                    _monthString = "July";
                    break;
                case 8:
                    _monthString = "August";
                    break;
                case 9:
                    _monthString = "September";
                    break;
                case 10:
                    _monthString = "October";
                    break;
                case 11:
                    _monthString = "November";
                    break;
                case 12:
                    _monthString = "December";
                    break;
                default:
                    _monthString = "Err Month";
                    break;
            }
        }





        public string GetMonthString(int month)
        {
            string monthString;

            switch (month)
            {
                case 1:
                    monthString = "January";
                    break;
                case 2:
                    monthString = "February";
                    break;
                case 3:
                    monthString = "March";
                    break;
                case 4:
                    monthString = "April";
                    break;
                case 5:
                    monthString = "May";
                    break;
                case 6:
                    monthString = "June";
                    break;
                case 7:
                    monthString = "July";
                    break;
                case 8:
                    monthString = "August";
                    break;
                case 9:
                    monthString = "September";
                    break;
                case 10:
                    monthString = "October";
                    break;
                case 11:
                    monthString = "November";
                    break;
                case 12:
                    monthString = "December";
                    break;
                default:
                    monthString = "Err Month";
                    break;
            }

            return monthString;
        }




        public string GetDayString(int day)
        {
            string dayString;

            switch (day)
            {
                case 1:
                    dayString = "Sunday";
                    break;
                case 2:
                    dayString = "Monday";
                    break;
                case 3:
                    dayString = "Tuesday";
                    break;
                case 4:
                    dayString = "Wednesday";
                    break;
                case 5:
                    dayString = "Thursday";
                    break;
                case 6:
                    dayString = "Friday";
                    break;
                case 7:
                    dayString = "Saturday";
                    break;
                default:
                    dayString = "Err Day";
                    break;
            }

            return dayString;
        }




        public void SetDaysInScope()
        {
            _daysInScope = new List<string>();
            _dayCodes = new List<int>();

            int day = _day;
            int month = _month;
            int year = _year;
            int numDaysInMonth = _numberOfDaysInMonth;

            string dayString;
            string dayOfWeekAlpha;
            string monthAlpha;
            string dayCode;

            for (int i = 0; i < _numDaysBeingDisplayed; i++, day++)
            {
                dayCode = "";

                if (day > numDaysInMonth)
                {
                    day = day - numDaysInMonth;
                    month++;

                    if (month > 12)
                    {
                        year++;
                        month = 1;
                    }

                    numDaysInMonth = DateTime.DaysInMonth(year, month);
                }


                DateTime currentDay = new DateTime(year, month, day, new GregorianCalendar());
                dayOfWeekAlpha = _myCal.GetDayOfWeek(currentDay).ToString();
                monthAlpha = GetMonthString(month);

                dayString = dayOfWeekAlpha + ", " + monthAlpha + " " + day.ToString();
                _daysInScope.Add(dayString);


                dayCode += _myCal.GetDayOfMonth(currentDay).ToString();
                dayCode += month.ToString();
                dayCode += year.ToString();
                _dayCodes.Add(Int32.Parse(dayCode));

                Console.WriteLine("Day Code: " + dayCode);
            }

        }




        public void ShiftDay(int amount)
        {
            int day = _day + amount;
            int month = _month;
            int year = _year;

            int daysInMonth = _myCal.GetDaysInMonth(year, month);

            while (day <= 0)
            {
                month--;

                if (month < 1)
                {
                    year--;
                    month = 12;
                }

                daysInMonth = _myCal.GetDaysInMonth(year, month);
                day = daysInMonth + day;
            }

            while (day > daysInMonth)
            {
                month++;

                if (month > 12)
                {
                    year++;
                    month = 1;
                }

                day = day - daysInMonth;
                daysInMonth = _myCal.GetDaysInMonth(year, month);
            }

            _day = day;
            _month = month;
            _year = year;

            InitModel();
        }



        private void FindRowCount(int month, int year)
        {
            int numberOfDaySlotsNeeded = _numberOfDaysInMonth + _dayToStartNumberingFrom;

            _rowsNeeded = numberOfDaySlotsNeeded / 7;

            if (numberOfDaySlotsNeeded % 7 != 0)
                _rowsNeeded++;

        }

        public void ChangeMonth(String direction)
        {
            if (direction == "next")
            {
                if (_month == 12)
                {
                    _year++;
                    _month = 1;
                }
                else
                    _month++;
            }
            else
            {
                if (_month == 1)
                {
                    _year--;
                    _month = 12;
                }
                else
                    _month--;
            }


            Console.WriteLine("\n\nYear is: " + _year + "\n\nMonth is: " + _month);

            InitModel();
        }




        public void GetNumberOfDaysInMonth()
        {
            _numberOfDaysInMonth = DateTime.DaysInMonth(_year, _month);
        }


        public void GetDayOfWeekForFirstDayOfMonth()
        {
            DateTime firstDayOfCurrentMonth = new DateTime(_year, _month, 1, new GregorianCalendar());
            _dayToStartNumberingFrom = (int)_myCal.GetDayOfWeek(firstDayOfCurrentMonth);

            return;
        }


        // Popualtes the private field with null strings where days are invalid for this month
        //    and with the numbers for the days where they should exist.
        public void GetDayNumberingSequence()
        {
            _daysToDisplayForMonth = new List<String>(42);

            for (int i = 0; i < _dayToStartNumberingFrom; i++)
            {
                _daysToDisplayForMonth.Add(null);
            }

            for (int i = 1; i <= _numberOfDaysInMonth; i++)
            {
                _daysToDisplayForMonth.Add(i.ToString());
            }

            for (int i = _numberOfDaysInMonth + _dayToStartNumberingFrom; i < 42; i++)
            {
                _daysToDisplayForMonth.Add(null);
            }
        }



    }
}