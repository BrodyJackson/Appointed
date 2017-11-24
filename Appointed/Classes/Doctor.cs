using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Events;

namespace Appointed.Classes
{

    public class Doctor : ObservableObject
    {
        string _doctorName;
        string _position;
        string _colour;
        string _visibility;
        string _columnWidth;
        int _shiftStart;
        int _shiftEnd;


        
        public Doctor(int start, int end, string visibility, string colWidth)
        {
            _shiftStart = start;
            _shiftEnd = end;
            _visibility = visibility;
            _columnWidth = colWidth;
        }

        public string DoctorName
        {
            get { return _doctorName; }
            set
            {
                _doctorName = value;
                RaisePropertyChangedEvent("DoctorName");
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                _position = value;
                RaisePropertyChangedEvent("Position");
            }
        }

        public string Colour
        {
            get { return _colour; }

            set
            {
                _colour = value;
                RaisePropertyChangedEvent("Colour");
            }
        }

        public string Visibility
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                RaisePropertyChangedEvent("Visibility");
            }
        }

        public string ColumnWidth
        {
            get { return _columnWidth; }
            set
            {
                _columnWidth = value;
                RaisePropertyChangedEvent("ColumnWidth");
            }
        }

        public int ShiftStart
        {
            get { return _shiftStart; }
        }


        public int ShiftEnd
        {
            get { return _shiftEnd; }
        }



        public bool IsAvailable(int time)
        {
            if (time >= _shiftStart && time <= _shiftEnd)
                return true;
            else
                return false;
        }
    }
}
