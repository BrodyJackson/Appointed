﻿using Appointed.Events;
using Appointed.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Classes;

namespace Appointed.ViewModels
{
    public class AppointmentViewModel : ObservableObject
    {
        private AppointmentDatabaseModel _adm;
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


            _numAppointmentsPerDay = 48;


            _doctorsOnShift = new ObservableCollection<Doctor>
            {
                new Doctor { DoctorName = "Dr. Pearson", Position = "0"},
                new Doctor { DoctorName = "Dr. Specter", Position = "1"},
                new Doctor { DoctorName = "Dr. Paulsen", Position = "2"}
            };




            // Adding empty Days for each doctor their schedule array where no corresponding fake appointments were made
            // Each column in the array is ine day of appointments
            AddEmptyDaysToArray(_pearsonAppointmentListArray, 0);
            AddEmptyDaysToArray(_specterAppointmentListArray, 1);
            AddEmptyDaysToArray(_paulsenAppointmentListArray, 2);

            // Adding the days that are populated with fake appointments to their corresponding slot in the array.
            // 0 is the beginning of time.
            _pearsonAppointmentListArray[20] = _adm._pearsonNovember032017;
            _pearsonAppointmentListArray[21] = _adm._pearsonNovember042017;
            _pearsonAppointmentListArray[22] = _adm._pearsonNovember052017;
            _pearsonAppointmentListArray[23] = _adm._pearsonNovember062017;
            _pearsonAppointmentListArray[24] = _adm._pearsonNovember072017;
            _pearsonAppointmentListArray[25] = _adm._pearsonNovember082017;
            _pearsonAppointmentListArray[52] = _adm._pearsonDecember052017;
            _pearsonAppointmentListArray[62] = _adm._pearsonDecember152017;
            _pearsonAppointmentListArray[63] = _adm._pearsonDecember162017;

            _specterAppointmentListArray[20] = _adm._specterNovember032017;
            _specterAppointmentListArray[21] = _adm._specterNovember042017;
            _specterAppointmentListArray[22] = _adm._specterNovember052017;
            _specterAppointmentListArray[23] = _adm._specterNovember062017;
            _specterAppointmentListArray[24] = _adm._specterNovember072017;
            _specterAppointmentListArray[25] = _adm._specterNovember082017;
            _specterAppointmentListArray[52] = _adm._specterDecember052017;
            _specterAppointmentListArray[62] = _adm._specterDecember152017;
            _specterAppointmentListArray[63] = _adm._specterDecember162017;

            _paulsenAppointmentListArray[20] = _adm._paulsenNovember032017;
            _paulsenAppointmentListArray[21] = _adm._paulsenNovember042017;
            _paulsenAppointmentListArray[22] = _adm._paulsenNovember052017;
            _paulsenAppointmentListArray[23] = _adm._paulsenNovember062017;
            _paulsenAppointmentListArray[24] = _adm._paulsenNovember072017;
            _paulsenAppointmentListArray[25] = _adm._paulsenNovember082017;
            _paulsenAppointmentListArray[52] = _adm._paulsenDecember052017;
            _paulsenAppointmentListArray[62] = _adm._paulsenDecember152017;
            _paulsenAppointmentListArray[63] = _adm._paulsenDecember162017;



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

                        Console.WriteLine("Appt Date: " + listOfAppointments[k].DateTime);
                        Console.WriteLine("Hash Code: " + (hashCode+i));

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
            List<Appointment> emptyDay;

            if (drID == 0)
                emptyDay = _adm._pearsonEmpty;
            else if (drID == 1)
                emptyDay = _adm._specterEmpty;
            else if (drID == 2)
                emptyDay = _adm._paulsenEmpty;
            else
            {
                Console.WriteLine("ERROR in AddEmptyDaysToArray: drID does not exist.");
                return;
            }

            for (int i = 0; i < 20; i++)
            {
                listOfAppointmentsArray[i] = new List<Appointment>();
                listOfAppointmentsArray[i].AddRange(emptyDay.Select(a => new Appointment(a)));
            }

            for (int i = 26; i < 52; i++)
            {
                listOfAppointmentsArray[i] = new List<Appointment>();
                listOfAppointmentsArray[i].AddRange(emptyDay.Select(a => new Appointment(a)));
            }

            for (int i = 53; i < 62; i++)
            {
                listOfAppointmentsArray[i] = new List<Appointment>();
                listOfAppointmentsArray[i].AddRange(emptyDay.Select(a => new Appointment(a)));
            }

            for (int i = 64; i < _numDaysPopulated; i++)
            {
                listOfAppointmentsArray[i] = new List<Appointment>();
                listOfAppointmentsArray[i].AddRange(emptyDay.Select(a => new Appointment(a)));
            }

            /*
                        for (int j = 0; j < _numAppointmentsPerDay; j++)
                        {
                            Appointment a = new Appointment(emptyDay.ElementAt(0));
                            listOfAppointmentsArray[i].Add(a);
                        }
            */
        }



        // Since empty appointment slots also have a unique key, get that key first to use this function.
        // The key is automatically bound to the <appt>.Tag property and is easily accessed in an event handler.
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


            emptyAppointment = new Appointment()
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
        


        public List<Appointment> PearsonEmpty
        {
            get { return _adm._pearsonEmpty; }
        }


        public List<Appointment> SpecterEmpty
        {
            get { return _adm._specterEmpty; }
        }



        public List<Appointment> PaulsenEmpty
        {
            get { return _adm._paulsenEmpty; }
        }
 

        // END PROPERTIES ====================================================


    }


    
}
