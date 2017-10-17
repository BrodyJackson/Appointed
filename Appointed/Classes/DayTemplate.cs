using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Events;

namespace Appointed.Classes
{


    public class DayTemplate : ObservableObject
    {
        int _startTime;
        int _hoursInScope;
        int daysInView;

        public int StartTime
        {
            get { return _startTime; }

            set
            {
                _startTime = value;
                RaisePropertyChangedEvent("StartTime");
            }
        }
    }



}
