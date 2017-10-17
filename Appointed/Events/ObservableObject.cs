using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Appointed.Events
{
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string dayNumberString)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(dayNumberString));
        }


    }
}
