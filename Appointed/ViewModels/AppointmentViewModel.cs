using Appointed.Events;
using Appointed.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointed.ViewModels
{

    public struct AppointmentStruct
    {
        public DateTime _dateTime;
        public string _doctorLastName;
        public string _type;
        public string _patient;
        public string _colour;
        public string _cursor;
        public string _rowSpan;
        public string _opacity;
        public string _height;
        public string _margin;
        public string _ID;        
        public string _comments;

        public int _startTime;
        public int _endTime;

        public bool _waitlisted;
        public bool _missed;
    }




    public class AppointmentViewModel : ObservableObject
    {
        AppointmentDatabaseModel _adm;
        private int _numDaysPopulated = 70;


        // Mapping of numeric code in format <position><month><day><year> where position is the column they are in (starting at 1)
        //      and month, day and year are the date in integer format ie 31/1/2017 or 1/1/2017.
        public Dictionary<int, List<Appointment>> _drScheduleMap;

        // Stores appointment with keys for quick lookup within onClick events in the schedule view.
        public Dictionary<int, Appointment> _appointmentLookup;

        // Used as a base to calculate the number of days elapsed.
        // Number of days elapsed is used to reference appointment lists in the array of appointment lists,=.
        private DateTime _beginningOfAllTime = new DateTime(2017, 10, 14);

        // To be set by the DIVM that instantiates an instance of this class.
        public int _numAppointmentsPerDay;

        // An array where each cell is a list of appointments.
        // Each list of appointments represents all appointments for one whole day for the doctor
        // The index "i" is the number of days since the beginning of all time (October 14, 2017)
        private List<Appointment>[] _pearsonAppointmentListArray;
        private List<Appointment>[] _specterAppointmentListArray;
        private List<Appointment>[] _paulsenAppointmentListArray;


        // A dictionary that pairs an int with the above data type.
        // The int represents a doctor's ID which must be the column the doctor is assigned to in the three day view.
        // This ID shouls match the position field in each Doctor object on the collection "_doctorsOnShift" found below.
        // The Doctor class is near the bottom of this file and it consists of a name and a position presented as observable properties.

        // Hence this structure contains an array of lists of appointments for each doctor. Each array represents all appointments since
        //      the beginning of time where the index is the number of days since the beginning of time. (October 14, 2017)
        //
        // Each dictionary entry corresponds to one doctor's array of lists of appointments.
        private Dictionary<int, List<Appointment>[]> _appointmentDictionary;


        private ObservableCollection<Doctor> _doctorsOnShift;



        private List<Appointment> _pearsonEmpty;
        private List<Appointment> _pearsonNovember032017;
        private List<Appointment> _pearsonNovember042017;
        private List<Appointment> _pearsonNovember052017;
        private List<Appointment> _pearsonNovember062017;
        private List<Appointment> _pearsonNovember072017;
        private List<Appointment> _pearsonNovember082017;
        private List<Appointment> _pearsonDecember052017;
        private List<Appointment> _pearsonDecember152017;
        private List<Appointment> _pearsonDecember162017;

        private List<Appointment> _specterEmpty;
        private List<Appointment> _specterNovember032017;
        private List<Appointment> _specterNovember042017;
        private List<Appointment> _specterNovember052017;
        private List<Appointment> _specterNovember062017;
        private List<Appointment> _specterNovember072017;
        private List<Appointment> _specterNovember082017;
        private List<Appointment> _specterDecember052017;
        private List<Appointment> _specterDecember152017;
        private List<Appointment> _specterDecember162017;


        private List<Appointment> _paulsenEmpty;
        private List<Appointment> _paulsenNovember032017;
        private List<Appointment> _paulsenNovember042017;
        private List<Appointment> _paulsenNovember052017;
        private List<Appointment> _paulsenNovember062017;
        private List<Appointment> _paulsenNovember072017;
        private List<Appointment> _paulsenNovember082017;
        private List<Appointment> _paulsenDecember052017;
        private List<Appointment> _paulsenDecember152017;
        private List<Appointment> _paulsenDecember162017;



        DayTemplate DT;




        public AppointmentViewModel()
        {
            _adm = new AppointmentDatabaseModel();
            DT = new DayTemplate { StartTime = 700 };
            _drScheduleMap = new Dictionary<int, List<Appointment>>();
            _appointmentLookup = new Dictionary<int, Appointment>();

            _pearsonAppointmentListArray = new List<Appointment>[_numDaysPopulated];
            _specterAppointmentListArray = new List<Appointment>[_numDaysPopulated];
            _paulsenAppointmentListArray = new List<Appointment>[_numDaysPopulated];


            _doctorsOnShift = new ObservableCollection<Doctor>
            {
                new Doctor { DoctorName = "Dr. Pearson", Position = "0"},
                new Doctor { DoctorName = "Dr. Specter", Position = "1"},
                new Doctor { DoctorName = "Dr. Paulsen", Position = "2"}
            };




            _numAppointmentsPerDay = 48;



            // Somewhat unnecessary. Gets info from appointment database and stores it in local variables.
            // Hides and protects information in the database by grabbing this info as a copy.
            _pearsonEmpty = _adm._pearsonEmpty;
            _pearsonNovember032017 = _adm._pearsonNovember032017;
            _pearsonNovember042017 = _adm._pearsonNovember042017;
            _pearsonNovember052017 = _adm._pearsonNovember052017;
            _pearsonNovember062017 = _adm._pearsonNovember062017;
            _pearsonNovember072017 = _adm._pearsonNovember072017;
            _pearsonNovember082017 = _adm._pearsonNovember082017;
            _pearsonDecember052017 = _adm._pearsonDecember052017;
            _pearsonDecember152017 = _adm._pearsonDecember152017;
            _pearsonDecember162017 = _adm._pearsonDecember162017;

            _specterEmpty = _adm._specterEmpty;
            _specterNovember032017 = _adm._specterNovember032017;
            _specterNovember042017 = _adm._specterNovember042017;
            _specterNovember052017 = _adm._specterNovember052017;
            _specterNovember062017 = _adm._specterNovember062017;
            _specterNovember072017 = _adm._specterNovember072017;
            _specterNovember082017 = _adm._specterNovember082017;
            _specterDecember052017 = _adm._specterDecember052017;
            _specterDecember152017 = _adm._specterDecember152017;
            _specterDecember162017 = _adm._specterDecember162017;

            _paulsenEmpty = _adm._paulsenEmpty;
            _paulsenNovember032017 = _adm._paulsenNovember032017;
            _paulsenNovember042017 = _adm._paulsenNovember042017;
            _paulsenNovember052017 = _adm._paulsenNovember052017;
            _paulsenNovember062017 = _adm._paulsenNovember062017;
            _paulsenNovember072017 = _adm._paulsenNovember072017;
            _paulsenNovember082017 = _adm._paulsenNovember082017;
            _paulsenDecember052017 = _adm._paulsenDecember052017;
            _paulsenDecember152017 = _adm._paulsenDecember152017;
            _paulsenDecember162017 = _adm._paulsenDecember162017;




            // Adding empty Days for each doctor their schedule array where no corresponding fake appointments were made
            // Each column in the array is ine day of appointments
            AddEmptyDaysToArray(_pearsonAppointmentListArray, 0);
            AddEmptyDaysToArray(_specterAppointmentListArray, 1);
            AddEmptyDaysToArray(_paulsenAppointmentListArray, 2);

            // Adding the days that are populated with fake appointments to their corresponding slot in the array.
            // 0 is the beginning of time.
            _pearsonAppointmentListArray[20] = _pearsonNovember032017;
            _pearsonAppointmentListArray[21] = _pearsonNovember042017;
            _pearsonAppointmentListArray[22] = _pearsonNovember052017;
            _pearsonAppointmentListArray[23] = _pearsonNovember062017;
            _pearsonAppointmentListArray[24] = _pearsonNovember072017;
            _pearsonAppointmentListArray[25] = _pearsonNovember082017;
            _pearsonAppointmentListArray[52] = _pearsonDecember052017;
            _pearsonAppointmentListArray[62] = _pearsonDecember152017;
            _pearsonAppointmentListArray[63] = _pearsonDecember162017;

            _specterAppointmentListArray[20] = _specterNovember032017;
            _specterAppointmentListArray[21] = _specterNovember042017;
            _specterAppointmentListArray[22] = _specterNovember052017;
            _specterAppointmentListArray[23] = _specterNovember062017;
            _specterAppointmentListArray[24] = _specterNovember072017;
            _specterAppointmentListArray[25] = _specterNovember082017;
            _specterAppointmentListArray[52] = _specterDecember052017;
            _specterAppointmentListArray[62] = _specterDecember152017;
            _specterAppointmentListArray[63] = _specterDecember162017;

            _paulsenAppointmentListArray[20] = _paulsenNovember032017;
            _paulsenAppointmentListArray[21] = _paulsenNovember042017;
            _paulsenAppointmentListArray[22] = _paulsenNovember052017;
            _paulsenAppointmentListArray[23] = _paulsenNovember062017;
            _paulsenAppointmentListArray[24] = _paulsenNovember072017;
            _paulsenAppointmentListArray[25] = _paulsenNovember082017;
            _paulsenAppointmentListArray[52] = _paulsenDecember052017;
            _paulsenAppointmentListArray[62] = _paulsenDecember152017;
            _paulsenAppointmentListArray[63] = _paulsenDecember162017;



            _appointmentDictionary = new Dictionary<int, List<Appointment>[]>
            {
                { 0, _pearsonAppointmentListArray },
                { 1, _specterAppointmentListArray },
                { 2, _paulsenAppointmentListArray }
            };


            PopulateAppointmentDatabase(DT.StartTime);


        }





        private void PopulateAppointmentDatabase(int startTime)
        {
            DateTime date;
            List<Appointment>[] listOfAppointmentsArray;
            List<Appointment> listOfAppointments;
            int hashCode;
            int time;
            string bindingCode = "";

            for (int i = 0; i < DoctorsOnShiftCount; i++)
            {
                listOfAppointmentsArray = _appointmentDictionary[i];

                for (int j = 0; j < _numDaysPopulated; j++)
                {
                    listOfAppointments = listOfAppointmentsArray[j];

                    date = _beginningOfAllTime.AddDays(j);
                    time = startTime;
                    for (int k = 0; k < listOfAppointments.Count; k++)
                    {
                        listOfAppointments[k].DateTime = new DateTime(date.Year, date.Month, date.Day, time / 100, time % 100, 0);

                        hashCode = listOfAppointments[k].DateTime.GetHashCode();
                        listOfAppointments[k].ID = (hashCode+i).ToString();

                        _appointmentLookup.Add(hashCode+i, listOfAppointments[k]);

                        listOfAppointments[k].StartTime = time;

                        if (listOfAppointments[k].Type.Equals("Consultation"))
                            time += 30;
                        else
                            time += 15;

                        if (time % 100 >= 60)
                            time += 40;

                        listOfAppointments[k].EndTime = time;
                    }

                    bindingCode = (i + 1).ToString() + date.Day.ToString() + date.Month.ToString() + date.Year.ToString();
                    _drScheduleMap.Add(Int32.Parse(bindingCode), listOfAppointments);

                    Console.WriteLine("Binding Code in dictionary: " + bindingCode);

                }
            }
        }


        private void AddEmptyDaysToArray(List<Appointment>[] listOfAppointmentsArray, int drID)
        {
            List<Appointment> emptyDay = _pearsonEmpty;

            if (drID == 1)
                emptyDay = _specterEmpty;

            if (drID == 2)
                emptyDay = _paulsenEmpty;

            for (int i = 0; i < 20; i++)
                listOfAppointmentsArray[i] = emptyDay;

            for (int i = 26; i < 52; i++)
                listOfAppointmentsArray[i] = emptyDay;

            for (int i = 53; i < 62; i++)
                listOfAppointmentsArray[i] = emptyDay;

            for (int i = 64; i < _numDaysPopulated; i++)
                listOfAppointmentsArray[i] = emptyDay;

        }



        // Since empty appointment slots also have a unique key, get that key first to use this function.
        // The key is automatically bound to the appt.Tag property and is easily accessed in an event handler.
        // In this scenario, the key refers to the key of the slot you would like to create the appointment in.
        // The appointment is the appointment you would like to place in that slot.
        // If the slot is not empty, it returns false and does nothing to the database.
        public bool AddAppointment (Appointment appointment, int key)
        {
            if (!(_appointmentLookup[key].Type.Length == 0))
            {
                Console.WriteLine("Appointment Type: " + _appointmentLookup[key].Type);
                return false;
            }
            int doctorColumn = 0;

            _appointmentLookup[key] = appointment;

            for (int i = 0; i < DoctorsOnShiftCount; i++)
            {
                if (DoctorsOnShift.ElementAt(i).DoctorName.Equals(appointment.DoctorName))
                    doctorColumn = i;

                Console.WriteLine("On Shift Name: " + DoctorsOnShift.ElementAt(i).DoctorName);
                Console.WriteLine("In Apptm Name: " + appointment.DoctorName);
                Console.WriteLine("In local Name: " + _pearsonEmpty.ElementAt(0).DoctorName);
            }

            InsertAppointment(doctorColumn, appointment);

            return true;
        }




        public void RemoveAppointment(int key)
        {
            Appointment appointment = _appointmentLookup[key];
            Appointment emptyAppointment;

            int doctorColumn = 0;
            string colour;

            for (int i = 0; i < DoctorsOnShiftCount; i++)
                if (DoctorsOnShift.ElementAt(i).DoctorName.Equals(appointment.DoctorName))
                    doctorColumn = i;

            colour = DoctorsOnShift.ElementAt(doctorColumn).Colour;


            emptyAppointment = new Appointment(new AppointmentStruct())
            { DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", Colour = colour, Cursor = "Hand", RowSpan = "1", Opacity = "0" };


            InsertAppointment(doctorColumn, emptyAppointment);
        }




        // Uses the date and doctor name in the argument "appointment" to overwrite an existing appointment with the argument's details.
        public void InsertAppointment(int doctorColumn, Appointment appointment)
        {
            List<Appointment> listOfAppointments;
            string bindingCode;
   

            bindingCode = (doctorColumn + 1).ToString() + appointment.DateTime.Day.ToString() + appointment.DateTime.Month.ToString() + appointment.DateTime.Year.ToString();
            listOfAppointments = _drScheduleMap[Int32.Parse(bindingCode)];

            for (int i = 0; i < listOfAppointments.Count; i++)
                if (appointment.DateTime.Hour.Equals(listOfAppointments.ElementAt(i).DateTime.Hour) && appointment.DateTime.Minute.Equals(listOfAppointments.ElementAt(i).DateTime.Minute))
                {
                    listOfAppointments.RemoveAt(i);
                    listOfAppointments.Insert(i, appointment);
                    break;
                }

            _drScheduleMap.Remove(Int32.Parse(bindingCode));
            _drScheduleMap.Add(Int32.Parse(bindingCode), listOfAppointments);

        }




        public int FindDrColumnForAppointment(Appointment appointment)
        {
            for (int i = 0; i < DoctorsOnShiftCount; i++)
                if (DoctorsOnShift.ElementAt(i).DoctorName.Equals(appointment.DoctorName))
                    return i;

            return -1;

        }


        public Appointment FindAppointmentThatFollows(Appointment appointment)
        {
            List<Appointment> listOfAppointments;
            DateTime date;
            string bindingCode;
            int drColumn;


            date = appointment.DateTime;

            drColumn = FindDrColumnForAppointment(appointment);
            bindingCode = (drColumn + 1).ToString() + date.Day.ToString() + date.Month.ToString() + date.Year.ToString();

            listOfAppointments = _drScheduleMap[Int32.Parse(bindingCode)];

            for (int i = 0; i < listOfAppointments.Count - 1; i++)
                if (appointment.ID == listOfAppointments.ElementAt(i).ID)
                    return listOfAppointments.ElementAt(i + 1);


            return null;
        }


        // PROPERTIES ====================================================
        // Shouldn't need these anymore since im binding to collections in the dictionary.

        public DateTime BeginningOfAllTime
        {
            get { return _beginningOfAllTime; }
        }


        public ObservableCollection<Doctor> DoctorsOnShift
        {
            get { return _doctorsOnShift; }

            set
            {
                _doctorsOnShift = new ObservableCollection<Doctor>(value);
                RaisePropertyChangedEvent("DoctorsOnShift");
                RaisePropertyChangedEvent("DoctorsOnShiftCount");
            }
        }


        public int DoctorsOnShiftCount
        {
            get { return DoctorsOnShift.Count; }            
        }
        


        // Pearson schedule data as gettable properties
        public List<Appointment> PearsonEmpty
        {
            get { return _pearsonEmpty; }
        }
        public List<Appointment> PearsonNovember32017
        {
            get { return _pearsonNovember032017; }

            set
            {
                _pearsonNovember032017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonNovember32017");
            }

        }
        public List<Appointment> PearsonNovember42017
        {
            get { return _pearsonNovember042017; }

            set
            {
                _pearsonNovember042017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonNovember42017");
            }

        }
        public List<Appointment> PearsonNovember52017
        {
            get { return _pearsonNovember052017; }

            set
            {
                _pearsonNovember052017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonNovember52017");
            }

        }
        public List<Appointment> PearsonNovember62017
        {
            get { return _pearsonNovember062017; }

            set
            {
                _pearsonNovember062017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonNovember62017");
            }

        }
        public List<Appointment> PearsonNovember72017
        {
            get { return _pearsonNovember072017; }

            set
            {
                _pearsonNovember072017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonNovember72017");
            }

        }
        public List<Appointment> PearsonNovember82017
        {
            get { return _pearsonNovember082017; }

            set
            {
                _pearsonNovember082017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonNovember82017");
            }

        }
        public List<Appointment> PearsonDecember52017
        {
            get { return _pearsonDecember052017; }

            set
            {
                _pearsonDecember052017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonDecember52017");
            }

        }
        public List<Appointment> PearsonDecember152017
        {
            get { return _pearsonDecember152017; }

            set
            {
                _pearsonDecember152017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonDecember152017");
            }

        }
        public List<Appointment> PearsonDecember162017
        {
            get { return _pearsonDecember162017; }

            set
            {
                _pearsonDecember162017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PearsonDecember162017");
            }

        }







        // Specter schedule data as gettable properties
        public List<Appointment> SpecterEmpty
        {
            get { return _specterEmpty; }
        }
        public List<Appointment> SpecterNovember32017
        {
            get { return _specterNovember032017; }

            set
            {
                _specterNovember032017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterNovember32017");
            }

        }
        public List<Appointment> SpecterNovember42017
        {
            get { return _specterNovember042017; }

            set
            {
                _specterNovember042017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterNovember42017");
            }

        }
        public List<Appointment> SpecterNovember52017
        {
            get { return _specterNovember052017; }

            set
            {
                _specterNovember052017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterNovember52017");
            }

        }
        public List<Appointment> SpecterNovember62017
        {
            get { return _specterNovember062017; }

            set
            {
                _specterNovember062017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterNovember62017");
            }

        }
        public List<Appointment> SpecterNovember72017
        {
            get { return _specterNovember072017; }

            set
            {
                _specterNovember072017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterNovember72017");
            }

        }
        public List<Appointment> SpecterNovember82017
        {
            get { return _specterNovember082017; }

            set
            {
                _specterNovember082017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterNovember82017");
            }

        }
        public List<Appointment> SpecterDecember52017
        {
            get { return _specterDecember052017; }

            set
            {
                _specterDecember052017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterDecember52017");
            }

        }
        public List<Appointment> SpecterDecember152017
        {
            get { return _specterDecember152017; }

            set
            {
                _specterDecember152017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterDecember152017");
            }

        }
        public List<Appointment> SpecterDecember162017
        {
            get { return _specterDecember162017; }

            set
            {
                _specterDecember162017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("SpecterDecember162017");
            }

        }











        // Paulsen schedule data as gettable properties
        public List<Appointment> PaulsenEmpty
        {
            get { return _paulsenEmpty; }
        }
        public List<Appointment> PaulsenNovember32017
        {
            get { return _paulsenNovember032017; }

            set
            {
                _paulsenNovember032017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenNovember32017");
            }

        }
        public List<Appointment> PaulsenNovember42017
        {
            get { return _paulsenNovember042017; }

            set
            {
                _paulsenNovember042017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenNovember42017");
            }

        }
        public List<Appointment> PaulsenNovember52017
        {
            get { return _paulsenNovember052017; }

            set
            {
                _paulsenNovember052017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenNovember52017");
            }

        }
        public List<Appointment> PaulsenNovember62017
        {
            get { return _paulsenNovember062017; }

            set
            {
                _paulsenNovember062017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenNovember62017");
            }

        }
        public List<Appointment> PaulsenNovember72017
        {
            get { return _paulsenNovember072017; }

            set
            {
                _paulsenNovember072017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenNovember72017");
            }

        }
        public List<Appointment> PaulsenNovember82017
        {
            get { return _paulsenNovember082017; }

            set
            {
                _paulsenNovember082017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenNovember82017");
            }

        }
        public List<Appointment> PaulsenDecember52017
        {
            get { return _paulsenDecember052017; }

            set
            {
                _paulsenDecember052017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenDecember52017");
            }

        }
        public List<Appointment> PaulsenDecember152017
        {
            get { return _paulsenDecember152017; }

            set
            {
                _paulsenDecember152017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenDecember152017");
            }

        }
        public List<Appointment> PaulsenDecember162017
        {
            get { return _paulsenDecember162017; }

            set
            {
                _paulsenDecember162017 = new List<Appointment>(value);
                RaisePropertyChangedEvent("PaulsenDecember162017");
            }

        }



        // END PROPERTIES ====================================================


    }



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
        


        public Appointment(AppointmentStruct apt)
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
