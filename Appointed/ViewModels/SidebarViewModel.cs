using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointed.Classes;


namespace Appointed.ViewModels
{
    public class SidebarViewModel
    {
        List<Alert> _alerts;
        Dictionary<int, Alert> _waitlistAlerts;


        public SidebarViewModel()
        {
            _alerts = new List<Alert>();
            _waitlistAlerts = new Dictionary<int, Alert>();
        }

        
        public List<Alert> Alerts
        {
            get { return _alerts; }
        }


        public Dictionary<int, Alert> WaitlistAlerts
        {
            get { return _waitlistAlerts; }
        }


        public void RemoveAlert(Alert a)
        {
            _waitlistAlerts.Remove(a.WLE.Key);
        }


        public void AddWaitlistAlert(Alert a)
        {
            if (_waitlistAlerts.ContainsKey(a.WLE.Key))
                return;

            _waitlistAlerts[a.WLE.Key] = a;
        }

    }
}
