using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace MammaSpy.ViewModels
{
	internal class ViewModelLocator
	{
		public MainWindowViewModel MainWindowViewModel =>
			App.Host.Services.GetRequiredService<MainWindowViewModel>();
		public DossierWindowViewModel DossierWindowViewModel =>
			App.Host.Services.GetRequiredService<DossierWindowViewModel>();
	}
}
