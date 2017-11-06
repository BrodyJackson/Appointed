using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Events;

namespace Appointed.Classes
{
    public class Date : ObservableObject
    {
        int _day;
        int _month;
        int _year;

        int _time24Hr;

        public Date()
        {

        }

        public int Day
        {
            get { return _day; }

            set
            {
                _day = value;
                RaisePropertyChangedEvent("Day");
            }
        }


        public int Month
        {
            get { return _month; }

            set
            {
                _month = value;
                RaisePropertyChangedEvent("Month");
            }
        }


        public int Year
        {
            get { return _year; }

            set
            {
                _year = value;
                RaisePropertyChangedEvent("Year");
            }
        }


        public int Time24Hr
        {
            get { return _time24Hr; }

            set
            {
                _time24Hr = value;
                RaisePropertyChangedEvent("Time24Hr");
            }
        }


    }
}
