using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MammaSpy.Model.VKAPIShell.Responses.Interfaces
{
	public interface IResponse<T>
	{
		[JsonPropertyName("response")]
		public T Response { get; set; }
	}
}
