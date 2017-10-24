using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointed.Classes
{
    public class Alert
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string ButtonText { get; set; }
        public EventHandler OnActionButtonClick { get; set; }

    }
}
