using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model
{
	internal static class Security
	{
		/// <summary>
		/// Заглушка, ну тип, надо же показать, что не все так просто у нас тут
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		internal static string Encrypt(string value, int key)
		{
			return value;
		}
		internal static string Decrypt(string value, int key)
		{
			return value;
		}
	}
}
