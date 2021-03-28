using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MammaSpy.Model.VKAPIShell.Entities
{
	public class FriendsList
	{
		[JsonPropertyName("count")]
		public int Count { get; set; }

		[JsonPropertyName("items")]
		public IList<int> Items { get; set; }
	}
}
