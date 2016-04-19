﻿using MEF.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MEF.WPF.Common
{
    public class ToggleViewCommand : ICommand
    {
        public ToggleViewCommand(MainWindowViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        MainWindowViewModel _ViewModel;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _ViewModel.OnToggleViewCommand();
        }
    }
}
