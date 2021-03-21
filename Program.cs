using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy
{
	
	internal static class Program
	{
		[STAThread]
		internal static void Main(string[] args)
		{
			var app = new App();
			app.InitializeComponent();
			app.Run();
		}
		internal static IHostBuilder CreateHostBuilder(string[] args)
		{
			IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);
			hostBuilder.UseContentRoot(App.CurrentDirectory);
			hostBuilder.ConfigureAppConfiguration((host, config) =>
			{
				config.SetBasePath(App.CurrentDirectory);
				config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
			});
			hostBuilder.ConfigureServices(App.ConfigureServices);
			return hostBuilder;
		}
	}
}
