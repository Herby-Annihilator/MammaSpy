using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.Services
{
	internal class ServiceLocator
	{
		public VKResponseParser VKResponseParser => App.Host.Services.GetRequiredService<VKResponseParser>();
	}
}
