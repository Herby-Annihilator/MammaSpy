using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using System.Text;

namespace MammaSpy.ViewModels.Base
{

	internal class ViewModel : MarkupExtension, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public override object ProvideValue(IServiceProvider serviceProvider) => this;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(propertyName);
			return true;
		}
	}
}
