﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Anime.Command
{
    public class RelayCommand : ICommand

    {

        public event EventHandler? CanExecuteChanged;

        private Action<object> execute;

        private RelayCommand(Action<object> execute)
        {
            this.execute = execute;
        }

        

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
