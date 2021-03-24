using MammaSpy.Model.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MammaSpy.Model.Services
{
	public class VKResponseParser : IParser
	{
		public T Parse<T>(string jsonString)
		{
			JsonSerializerOptions options = new JsonSerializerOptions()
			{
				Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			};
			T result = JsonSerializer.Deserialize<T>(jsonString, options);
			return result;
		}
	}
}
