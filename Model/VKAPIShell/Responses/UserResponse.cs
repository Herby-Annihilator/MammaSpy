using MammaSpy.Model.VKAPIShell.Responses.Interfaces;
using MammaSpy.Model.VKAPIShell.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MammaSpy.Model.VKAPIShell.Responses
{
	public class UserResponse : IResponse<IList<User>>
	{
		[JsonPropertyName("response")]
		public IList<User> Response { get; set; }
	}
}
