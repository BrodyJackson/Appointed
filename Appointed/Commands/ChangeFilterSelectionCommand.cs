using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Appointed.Commands
{
    public class ChangeFilterSelectionCommand : ICommand
    {
        private readonly Action<int> _action;

        public ChangeFilterSelectionCommand(Action<int> action)
        {
            _action = action;
        }

        public void Execute(object location)
        {
            _action((int)location);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }
    }
}
