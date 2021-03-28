using MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.Common
{
	public class UserFieldsParameter : UserParameter
	{
		public override string Name => "fields";
		public UserFieldsParameter(FieldsValues fieldsValues)
		{
			Value = fieldsValues.ToString().Replace(" ", "");
		}
	}

	[Flags]
	public enum FieldsValues : uint
	{
		none = 0,
		bdate = 1,
		home_town = 2,
		photo_200 = 4,
		schools = 8,
		country = 16,
		followers_count = 32
	}
}
