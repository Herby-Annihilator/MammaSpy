using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.Services
{
	internal static class ServiceRegistrator
	{
		internal static IServiceCollection RegisterServices(this IServiceCollection services)
		{
			services.AddTransient<VKResponseParser>();
			return services;
		}
	}
}
