using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace MammaSpy.ViewModels
{
	internal static class ViewModelRegistrator
	{
		internal static IServiceCollection RegisterViewModels(this IServiceCollection services)
		{
			services.AddSingleton<MainWindowViewModel>();
			return services;
		}
	}
}
