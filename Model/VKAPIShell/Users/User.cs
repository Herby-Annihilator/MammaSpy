using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MammaSpy.Model.VKAPIShell.Users
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
		

		public override string ToString()
		{
			return $"{nameof(FirstName)} {FirstName}\r\n" +
				$"{nameof(LastName)} {LastName}\r\n";
		}
	}
}
