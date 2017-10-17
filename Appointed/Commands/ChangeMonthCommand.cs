using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Appointed.Commands
{
    public class ChangeMonthCommand : ICommand
    {
        private readonly Action<String> _action;
        private readonly String _direction;

        public ChangeMonthCommand(String direction, Action<String> action)
        {
            _direction = direction;
            _action = action;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine(_direction);
            _action(_direction);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }
    }


}
