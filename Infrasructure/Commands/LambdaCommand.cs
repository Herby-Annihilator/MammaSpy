using MammaSpy.Infrasructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Infrasructure.Commands
{
	public class LambdaCommand : Command
	{
		private Action<object> _execute;
		private Func<object, bool> _canExecute;
		public override bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

		public override void Execute(object parameter)
		{
			if (!CanExecute(parameter)) return;
			_execute.Invoke(parameter);
		}
		public LambdaCommand(Action<object> execute, Func<object, bool> canExecute)
		{
			_execute = execute ?? throw new ArgumentException(nameof(execute));
			_canExecute = canExecute;
		}
	}
}
