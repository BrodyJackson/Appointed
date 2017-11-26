using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Appointed.Classes
{
    public class Alert
    {
        public string Title { get; set; }
        public BitmapImage Icon { get; set; }
        public string ButtonText { get; set; }
        public EventHandler OnActionButtonClick { get; set; }
        public EventHandler OnDeleteButtonClick { get; set; }


        public Alert()
        {
            Icon = Assets.ResourceManager.Instance.Images["InfoIcon"];
        }

    }
}
