using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Appointed.Assets
{
    class ResourceManager
    {
        private static ResourceManager _instance = new ResourceManager();

        public static ResourceManager Instance
        {
            get
            {
                return _instance;
            }
        }

        public Dictionary<String, BitmapImage> Images { get; private set; }

        private ResourceManager()
        {
            Images = new Dictionary<string, BitmapImage>();

            AddImage("HomeIcon", "HomeIcon.png");
            AddImage("ReturnIcon", "ReturnIcon.png");
            AddImage("InfoIcon", "InfoIcon.png");
            AddImage("TrashIcon", "TrashIcon.png");
            AddImage("NewPatientIcon", "NewPatientIcon.png");
            AddImage("SearchIcon", "SearchIcon.png");
            AddImage("EditIcon", "EditIcon.png");
            AddImage("RightArrow", "RightArrow.png");
            AddImage("LeftArrow", "LeftArrow.png");
            AddImage("RightDblArrow", "RightDblArrow.png");
            AddImage("LeftDblArrow", "LeftDblArrow.png");
            AddImage("CalendarIcon", "CalendarIcon.png");
            AddImage("DayIcon", "DayIcon.png");
            AddImage("SaveIcon", "SaveIcon.jpg");


        }

        private void AddImage(String key, String name)
        {
            Images.Add(key, new BitmapImage(new Uri("pack://application:,,,/Appointed;component/Assets/" + name)));
        }


    }
}
