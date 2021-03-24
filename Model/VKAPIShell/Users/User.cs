using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MammaSpy.Model.VKAPIShell.Users
{
	public class User
	{
		public int id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public bool is_closed { get; set; }
		public bool can_access_closed { get; set; }
		

		public override string ToString()
		{
			return $"{nameof(first_name)} {first_name}\r\n" +
				$"{nameof(last_name)} {last_name}\r\n";
		}
	}
}
