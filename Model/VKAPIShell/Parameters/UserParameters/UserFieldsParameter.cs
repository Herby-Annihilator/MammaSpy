using MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters
{
	public class UserFieldsParameter : UserParameter
	{
		public override string Name => "fields";
		public UserFieldsParameter(FieldsValues fieldsValues)
		{
			Value = fieldsValues.GetStringEquivalent();
		}
	}

	[Flags]
	public enum FieldsValues : uint
	{
		None = 0,
		BirthdayDate = 1,
		HomeTown = 2,
		PathToUserPhoto = 4,
		Schools = 8,
		Country = 16,
		FollowersCount = 32
	}

	public static class FieldsValuesExtension
	{
		public static string GetStringEquivalent(this FieldsValues values)
		{
			return values switch
			{
				FieldsValues.BirthdayDate => "bdate",
				FieldsValues.HomeTown => "home_town",
				FieldsValues.PathToUserPhoto => "photo_200",
				FieldsValues.Schools => "schools",
				FieldsValues.Country => "country",
				FieldsValues.FollowersCount => "followers_count",
				_ => "bdate"
			};
		}
	}
}
