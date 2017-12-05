using Appointed.Views.Sidebar.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointed.Classes
{
    public class MessageBoxEventArgs : EventArgs
    {
        public MyMessageBox.Result result;
    }
}
