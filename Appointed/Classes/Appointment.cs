using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Events;

namespace Appointed.Classes
{

    public class Appointment : ObservableObject
    {
        DateTime _dateTime;
        string _doctorName;
        string _type;
        string _patient;
        string _colour;
        string _cursor;
        string _rowSpan;
        string _opacity;
        string _height;
        string _margin;
        string _visibility;
        string _ID;
        string _comments;
        int _startTime;
        int _endTime;
        bool _missed;
        bool _waitlisted;



        public Appointment()
        {



        }


        public Appointment(Appointment toCopy)
        {
            this.Colour = toCopy.Colour;
            this.Comments = toCopy.Comments;
            this.Cursor = toCopy.Cursor;
            this.DateTime = toCopy.DateTime;
            this.DoctorName = toCopy.DoctorName;
            this.EndTime = toCopy.EndTime;
            this.Height = toCopy.Height;
            this.ID = toCopy.ID;
            this.Margin = toCopy.Margin;
            this.Missed = toCopy.Missed;
            this.Opacity = toCopy.Opacity;
            this.Patient = toCopy.Patient;
            this.RowSpan = toCopy.RowSpan;
            this.StartTime = toCopy.StartTime;
            this.Type = toCopy.Type;
            this.Waitlisted = toCopy.Waitlisted;
            this.Visibility = toCopy.Visibility;
        }


        public DateTime DateTime
        {
            get { return _dateTime; }
            set
            {
                _dateTime = value;
                RaisePropertyChangedEvent("DateTime");
            }
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

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                RaisePropertyChangedEvent("Type");
                RaisePropertyChangedEvent("AppointmentInfo");
            }
        }

        public string Patient
        {
            get { return _patient; }
            set
            {
                _patient = value;
                RaisePropertyChangedEvent("Patient");
                RaisePropertyChangedEvent("AppointmentInfo");
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

        public string Cursor
        {
            get { return _cursor; }
            set
            {
                _cursor = value;
                RaisePropertyChangedEvent("Cursor");
            }
        }

        public string RowSpan
        {
            get { return _rowSpan; }
            set
            {
                _rowSpan = value;
                RaisePropertyChangedEvent("RowSpan");
            }
        }

        public string Opacity
        {
            get { return _opacity; }
            set
            {
                _opacity = value;
                RaisePropertyChangedEvent("Opacity");
            }
        }


        public string Height
        {
            get { return _height; }
            set
            {
                _height = value;
                RaisePropertyChangedEvent("Height");
            }
        }


        public string AppointmentInfo
        {
            get
            {
                if (Patient.Length != 0 && Type.Length != 0)
                {
                    if (Patient.Length > 15)
                    {
                        int whiteSpaceIndex = Patient.IndexOf(' ');
                        string shortenedInfo = Patient.ElementAt(0).ToString() + "." + Patient.Substring(whiteSpaceIndex);
                        return shortenedInfo + ":\n" + Type;
                    }
                    else
                        return Patient + ":\n" + Type;
                }
                else
                    return "";
            }
        }


        public string Margin
        {
            get { return _margin; }
            set
            {
                _margin = value;
                RaisePropertyChangedEvent("Margin");
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

        public string ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                RaisePropertyChangedEvent("ID");
            }
        }

        public string Comments
        {
            get { return _comments; }

            set
            {
                _comments = value;
                RaisePropertyChangedEvent("Comments");
            }
        }

        public int StartTime
        {
            get { return _startTime; }

            set
            {
                _startTime = value;
                RaisePropertyChangedEvent("StartTime");
            }
        }

        public int EndTime
        {
            get { return _endTime; }

            set
            {
                _endTime = value;
                RaisePropertyChangedEvent("EndTime");
            }
        }

        public bool Missed
        {
            get { return _missed; }

            set
            {
                _missed = value;
                RaisePropertyChangedEvent("Missed");
            }
        }

        public bool Waitlisted
        {
            get { return _waitlisted; }

            set
            {
                _waitlisted = value;
                RaisePropertyChangedEvent("Waitlisted");
            }

        }
    }

}
