using MammaSpy.Infrasructure.Converters.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MammaSpy.Infrasructure.Converters
{
	public class IntIDToStringIDConverter : Converter
	{
		/// <summary>
		/// На вход int, выход - string
		/// </summary>
		/// <param name="value">int - то, что пришло из ViewModel</param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns>string</returns>
		public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!(value is int?)) return "";
			if ((int?)value == 0) return "";
			return ((int?)value).ToString();
		}
		/// <summary>
		/// На вход string, выход - int
		/// </summary>
		/// <param name="value">string - то, что пришло из View</param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns>int</returns>
		public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!int.TryParse((string)value, out int a))
				return 0;
			else
				return a;
		}
	}
}
