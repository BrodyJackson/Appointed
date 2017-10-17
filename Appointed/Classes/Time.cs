using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Events;

namespace Appointed.Classes
{
    public class Time : ObservableObject
    {
        string _timeString;

        public string TimeString
        {
            get { return _timeString; }
            set
            {
                _timeString = value;
                RaisePropertyChangedEvent("TimeString");
            }
        }
    }

}
