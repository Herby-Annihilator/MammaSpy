using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MammaSpy.Model
{
	public static class InputOutput
	{
		private static string ServiseFileName { get; set; } = "ServiceFile.txt";
		private static string SecureFileName { get; set; } = "SecureFile.txt";
		private static string ApplicationIDFileName { get; set; } = "AppID.txt";
		private static string VKAPIVersionFileName { get; set; } = "VkAPIVersion.txt";
		private static string GetFileContent(string fileName)
		{
			try
			{
				string result;
				StreamReader reader = new StreamReader(fileName);
				result = reader.ReadToEnd().Trim();
				reader.Close();
				return result;
			}
			catch(Exception)
			{
				return "";
			}
		}
		public static string GetServiceKey() => GetFileContent(ServiseFileName);
		public static string GetSecureKey() => GetFileContent(SecureFileName);
		public static string GetApplicationID() => GetFileContent(ApplicationIDFileName);
		public static string GetAPIVersion() => GetFileContent(VKAPIVersionFileName);
	}
}
