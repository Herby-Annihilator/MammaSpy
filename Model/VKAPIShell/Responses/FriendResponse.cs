using MammaSpy.Model.VKAPIShell.Entities;
using MammaSpy.Model.VKAPIShell.Responses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MammaSpy.Model.VKAPIShell.Responses
{
	public class FriendResponse : IResponse<FriendsList>
	{
		[JsonPropertyName("response")]
		public FriendsList Response { get; set; }
	}
}
