using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MammaSpy.Model.VKAPIShell.Entities
{
	public class User
	{
		[JsonPropertyName("id")]
		public int ID { get; set; }

		[JsonPropertyName("first_name")]
		public string FirstName { get; set; }

		[JsonPropertyName("last_name")]
		public string LastName { get; set; }

		[JsonPropertyName("is_closed")]
		public bool IsClosed { get; set; }

		[JsonPropertyName("can_access_closed")]
		public bool CanAccessClosed { get; set; }

		[JsonPropertyName("home_town")]
		public string HomeTown { get; set; }

		[JsonPropertyName("followers_count")]
		public int FollowersCount { get; set; }

		[JsonPropertyName("country")]
		public Country Country { get; set; }

		[JsonPropertyName("photo_200")]
		public string PathToUserPhoto { get; set; }

		[JsonPropertyName("schools")]
		public IList<School> Schools { get; set; }

		[JsonPropertyName("bdate")]
		public string Birthday { get; set; }

		[JsonPropertyName("career")]
		public Career Career { get; set; }

		public override string ToString()
		{
			return $"{nameof(FirstName)} {FirstName}\r\n" +
				$"{nameof(LastName)} {LastName}\r\n";
		}
	}

	public class Country
	{
		[JsonPropertyName("id ")]
		public int ID { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }
	}

	public class School
	{
		[JsonPropertyName("id")]
		public string ID { get; set; }

		[JsonPropertyName("country")]
		public int Country { get; set; }

		[JsonPropertyName("city")]
		public int City { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("year_from")]
		public int YearFrom { get; set; }

		[JsonPropertyName("year_to")]
		public int YearTo { get; set; }

		[JsonPropertyName("year_graduated")]
		public int YearGraduated { get; set; }

		[JsonPropertyName("class")]
		public string Class { get; set; }

		[JsonPropertyName("speciality")]
		public string Speciality { get; set; }

		[JsonPropertyName("type")]
		public int Type { get; set; }

		[JsonPropertyName("type_str")]
		public string TypeStr { get; set; }
	}

	public class Career
	{
		[JsonPropertyName("position")]
		public string Position { get; set; }

		[JsonPropertyName("group_id")]
		public int GroupId { get; set; }

		[JsonPropertyName("company")]
		public string Company { get; set; }

		[JsonPropertyName("country_id")]
		public int CountryId { get; set; }

		[JsonPropertyName("city_id")]
		public int CityId { get; set; }

		[JsonPropertyName("city_name")]
		public string  CityName { get; set; }

		[JsonPropertyName("from")]
		public int From { get; set; }

		[JsonPropertyName("until")]
		public int Until { get; set; }
	}
}
