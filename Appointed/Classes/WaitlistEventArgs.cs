using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointed.Classes
{
    public class WaitlistEventArgs : EventArgs
    {
        // Should be constructed with the desired doctor name, desired date, and key for the appt that is waiting
        public string DoctorName { get; set; }
        public Date Date { get; set; }
        public int Key { get; set; }
    }
}
