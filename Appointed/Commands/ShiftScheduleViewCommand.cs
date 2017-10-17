using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Appointed.Commands
{
    public class ShiftScheduleViewCommand : ICommand
    {
        private readonly Action<int> _action;


        public ShiftScheduleViewCommand(Action<int> action)
        {
            _action = action;
        }

        public void Execute(object parameter)
        {
            _action((int) parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }
    }
}
