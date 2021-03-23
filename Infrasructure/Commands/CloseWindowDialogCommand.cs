using MammaSpy.Infrasructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MammaSpy.Infrasructure.Commands
{
	public class CloseWindowDialogCommand : Command
	{
		public bool? DialogResult { get; set; }
		public override bool CanExecute(object parameter)
		{
			return parameter is Window;
		}

		public override void Execute(object parameter)
		{
			if (!CanExecute(parameter)) return;
			Window window = (Window)parameter;
			window.DialogResult = DialogResult;
			window.Close();
		}
	}
}
