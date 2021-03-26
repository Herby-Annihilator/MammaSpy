using MammaSpy.Infrasructure.Converters.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Net.Cache;

namespace MammaSpy.Infrasructure.Converters
{
	public class ServerAnswerToRealPathConverter : Converter
	{
		public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null) return null;
			BitmapImage image = new BitmapImage();
			image.BeginInit();
			image.UriSource = new Uri((string)value);
			image.EndInit();
			return image;
		}
	}
}
