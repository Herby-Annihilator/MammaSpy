﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.CompilerServices;
using System.IO;
using MammaSpy.ViewModels;
using MammaSpy.Model.Services;

namespace MammaSpy
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static bool IsDesignMode { get; private set; } = true;
		private static IHost _host;
		public static string CurrentDirectory => IsDesignMode ? Path.GetDirectoryName(GetSourceCodePath()) :
			Environment.CurrentDirectory;
		public static IHost Host => _host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs())
			.Build();

		protected override async void OnStartup(StartupEventArgs e)
		{
			IsDesignMode = false;
			var host = Host;
			base.OnStartup(e);
			await host.StartAsync().ConfigureAwait(false);
		}
		protected override async void OnExit(ExitEventArgs e)
		{
			base.OnExit(e);
			var host = Host;
			await host.StopAsync().ConfigureAwait(false);
			host.Dispose();
			_host = null;
		}

		internal static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
		{
			services.RegisterViewModels();
			services.RegisterServices();
		}
		private static string GetSourceCodePath([CallerFilePath] string path = null)
		{
			return path;
		}
	}
}
