using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.ViewModels;

namespace Appointed.Classes
{
    public class Waitlist
    {
        private Dictionary<int, List<Appointment>> waitlist;

        public Waitlist()
        {
            waitlist = new Dictionary<int, List<Appointment>>();
        }

        
        // Searches the waitlist to determine if an appointment is waiting for the slot Appointment 'a' occupies.
        //      If Appointment 'a' was not the head of any waitlist, it returns 'a'.
        //      If Appointment 'a' was associated with a queue but no elements were found in the queue, it returns null.
        //      Otherwise it returns the first appointment in line waiting for the time slot Appointment 'a' occupies.
        // The idea is to call this before deleting an appointment, where the appointment you are about to delete is
        // the parameter 'a'. This will tell you if any appointments were waiting for the slot 'a' occupies and will return
        // the appointment if it exists.
        // Since I'm not 100% certain how C# returns objects, the Appointment returned may only be useful for it's ID field which can
        // be used as the key to find the appointment in the dictionary '_appointmentLookup' where the reference to the appointment that was
        // waiting can be retrieved and used directly to modify it's fields. Modifying the fields of the return value may not have any effect
        // on the appointment in the database.
        public Appointment GetApptWaiting(Appointment a)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;

            int key = a.DateTime.GetHashCode() + DIVM.AVM.FindDrColumnForDrName(a.DoctorName);

            if (!DIVM.AVM._appointmentLookup.ContainsKey(key))
                return a;

            Appointment b = DIVM.AVM._appointmentLookup[key];

            if (waitlist.ContainsKey(key))
            {
                int i = 0;
                while (i < waitlist[key].Count && waitlist[key].ElementAt(i) == null)
                    i++;

                if (i < waitlist[key].Count)
                {
                    b = waitlist[key].ElementAt(i);

                    waitlist[key].RemoveAt(i);
                    return b;
                }

                return null;
            }

            return a;
        }


        // Add Appointment 'apptToAdd' to the waitlist for the appointment slot identified by the 'dateDesired' and the 'nameOfDocDesired'.
        // If 'nameOfDocDesired' is invalid it returns -1 and does not modify the waitlist.
        // 'apptToAdd' should have it's DateTime and ID set according to the slot it currently occupies, not the slot
        // it wishes to wait for.
        // Returns the zero based waitlist position of this Appointment for this slot.
        public int AddAppointment(Appointment apptToAdd, DateTime dateDesired, string nameOfDocDesired)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;

            if (DIVM.AVM.DoctorsOnShift.All(x => x.DoctorName != nameOfDocDesired))
                return -1;

            int key = dateDesired.GetHashCode() + DIVM.AVM.FindDrColumnForDrName(nameOfDocDesired);

            if (waitlist.ContainsKey(key) && waitlist[key] != null)
                waitlist[key].Add(apptToAdd);
            else
                waitlist[key] = new List<Appointment> { apptToAdd };

            return (waitlist[key].Count - 1);
        }


        // Remove Appointment 'apptToRemove' from the waitlist.
        // Cannot be undone - have to be placed at the back of the queue to re-enter waitlist.
        public void RemoveAppointment(Appointment apptToRemove)
        {
            DayInformationViewModel DIVM = App.Current.MainWindow.DataContext as DayInformationViewModel;

            foreach (KeyValuePair<int, List<Appointment>> Q in waitlist)
            {
                for (int i = 0; i < Q.Value.Count; i++)
                {
                    Appointment a = Q.Value.ElementAt(i);
                    if (a.ID == apptToRemove.ID)
                    {
                        Q.Value.RemoveAt(i);
                        return;
                    }
                }
            }

            return;
        }




    }
}
