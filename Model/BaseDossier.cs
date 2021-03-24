using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MammaSpy.Model
{
	public class BaseDossier
	{
		[JsonPropertyName("first_name")]
		public string FirstName { get; set; } = "not found";
		[JsonPropertyName("last_name")]
		public string LastName { get; set; } = "not found";
		[JsonPropertyName("nickname")]
		public string Patronymic { get; set; } = "not found";

		public int Age { get; set; } = 0;

		public string Address { get; set; } = "not found";
		[JsonPropertyName("education")]
		public string StudyPlace { get; set; } = "not found";
		[JsonPropertyName("occupation")]
		public string JobPlace { get; set; } = "not found";
	}
}
