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

    }
}
