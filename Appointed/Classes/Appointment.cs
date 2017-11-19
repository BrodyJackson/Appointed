using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Events;
using Appointed.ViewModels;

namespace Appointed.Classes
{
    // Need to add.. 
    //  Strings for start and end time, colon separated - StartTimeStr, EndTimeStr
    //  
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
        string _waitlistPos;
        string _isClickable;
        int _startTime;
        int _endTime;
        bool _missed;
        bool _waitlisted;
        bool _arrived;

        string _reminderType;
        string _reminderDays;
        string _reminderTimeOfDay;



        public Appointment()
        {



        }

        // Make sure to add to this as fields are added to appointment class.
        // If not done, bindings will not resolve.
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
            this.Arrived = toCopy.Arrived;
            this.Opacity = toCopy.Opacity;
            this.Patient = toCopy.Patient;
            this.RowSpan = toCopy.RowSpan;
            this.StartTime = toCopy.StartTime;
            this.Type = toCopy.Type;
            this.Waitlisted = toCopy.Waitlisted;
            this.WaitlistPos = toCopy.WaitlistPos;
            this.IsClickable = toCopy.IsClickable;
            this.Visibility = toCopy.Visibility;
            this.ReminderDays = toCopy.ReminderDays;
            this.ReminderTimeOfDay = toCopy.ReminderTimeOfDay;
            this.ReminderType = toCopy.ReminderType;
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
                RaisePropertyChangedEvent("DrColumn");
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
                RaisePropertyChangedEvent("TypeIndex");
            }
        }

        public string Patient
        {
            get { return _patient; }
            set
            {
                _patient = value;
                RaisePropertyChangedEvent("PatientNameAbbrev");
                RaisePropertyChangedEvent("Patient");
                RaisePropertyChangedEvent("AppointmentInfo");
            }
        }

        public string PatientNameAbbrev
        {
            get
            {
                    string shortenedInfo;
                    int whiteSpaceIndex;

                    if (Patient.Length > 12)
                    {
                        whiteSpaceIndex = Patient.IndexOf(' ');
                        shortenedInfo = Patient.ElementAt(0).ToString() + "." + Patient.Substring(whiteSpaceIndex);
                    }
                    else
                        return Patient;
                    
                    if (shortenedInfo.Length > 12)
                    {
                        whiteSpaceIndex = shortenedInfo.IndexOf(' ');
                        shortenedInfo = shortenedInfo.Substring(0, whiteSpaceIndex) + " " + shortenedInfo.Substring(whiteSpaceIndex+1, 8) + "..";
                    }

                    return shortenedInfo;
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
                RaisePropertyChangedEvent("StartTimeStr");
            }
        }

        public string StartTimeStr
        {
            get
            {
                string startTimeStr = _startTime.ToString();

                if (startTimeStr.Length >= 3)
                    return startTimeStr.Substring(0, startTimeStr.Length - 2) + ":" + startTimeStr.Substring(startTimeStr.Length - 2);
                else
                    return startTimeStr;
            }
        }

        public int EndTime
        {
            get { return _endTime; }

            set
            {
                _endTime = value;
                RaisePropertyChangedEvent("EndTime");
                RaisePropertyChangedEvent("EndTimeStr");
            }
        }

        public string EndTimeStr
        {
            get
            {
                string endTimeStr = _endTime.ToString();

                if (endTimeStr.Length >= 3)
                    return endTimeStr.Substring(0, endTimeStr.Length - 2) + ":" + endTimeStr.Substring(endTimeStr.Length - 2);
                else
                    return endTimeStr;
            }
        }

        public int DrColumn
        {
            get
            {
                DayInformationViewModel DIVM = new DayInformationViewModel();

                return DIVM.AVM.FindDrColumnForDrName(_doctorName);
            }
        }


        public int TypeIndex
        {
            get { return _type == "Standard" ? 0 : 1; }
        }

        public int TimeIndex
        {
            get { return ( (_startTime % 100)  / 15)   +   (((_startTime / 100) - 7) * 4)  ; }
        }

        public int RemDaysIndex
        {
            get { return _reminderDays == null ? 1 : Int32.Parse(_reminderDays); }
        }

        public int RemTypeIndex
        {
            get
            {
                if ( _reminderType == null || _reminderType == "Email" )
                    return 0;
                else if ( _reminderType == "Text" )
                    return 1;
                else
                    return 2;
            }
        }

        public int RemTODIndex
        {
            get { return _reminderTimeOfDay == "AM" ? 0 : 1; }
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

        public bool Arrived
        {
            get { return _arrived; }

            set
            {
                _arrived = value;
                RaisePropertyChangedEvent("Arrived");                
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


        public string WaitlistPos
        {
            get
            {
                if (_waitlisted)
                {
                    return _waitlistPos;
                }
                else
                    return "N/A";
            }

            set
            {
                _waitlistPos = value;
                RaisePropertyChangedEvent("WaitlistPos");
            }
        }


        public string IsClickable
        {
            get { return _isClickable; }
            set
            {
                _isClickable = value;
                RaisePropertyChangedEvent("IsClickable");
            }
        }

        public string ReminderType
        {
            get { return _reminderType; }
            set
            {
                _reminderType = value;
                RaisePropertyChangedEvent("ReminderType");
            }

        }


        public string ReminderTimeOfDay
        {
            get { return _reminderTimeOfDay; }
            set
            {
                _reminderTimeOfDay = value;
                RaisePropertyChangedEvent("ReminderTimeOfDay");
            }

        }


        public string ReminderDays
        {
            get { return _reminderDays; }
            set
            {
                _reminderDays = value;
                RaisePropertyChangedEvent("ReminderDays");
            }

        }


    }

}
