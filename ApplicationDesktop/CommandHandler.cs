using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ApplicationDesktop
{
    public class CommandHandler : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly Action _action;
        private readonly Func<bool> _canExecute;

        public CommandHandler(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;

        }


        public bool CanExecute(object? parameter)
        {
            return _canExecute?.Invoke() ?? true ;
        }

        public void Execute(object? parameter)
        {
            _action?.Invoke();
        }
    }
}
