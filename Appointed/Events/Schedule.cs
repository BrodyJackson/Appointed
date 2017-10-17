using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointed.Events
{
    public interface ISchedule
    {
        // Delegate -- Classes can subscribe their methods to this event to be called when event is raised.
        event EventHandler<EventArgs> ScheduleShifted;


    }
}
