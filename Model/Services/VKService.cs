using MammaSpy.Model.VKAPIShell.Users;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MammaSpy.Model.Services
{
	public class VKService
	{
		private string _start;
		private string _version;
		private string _accessToken;
		private HttpClient _httpClient;
		public VKService()
		{
			_start = "https://api.vk.com/method/";
			_version = $"&v={InputOutput.GetAPIVersion() ?? "5.130"}";
			_accessToken = $"access_token={InputOutput.GetServiceKey()}";
			_httpClient = new HttpClient();
		}
		private string ConfigureQuery(Method method) => _start + method.GenerateQueryString() + 
			_accessToken + _version;
		public async Task<string> GetMethodResultAsync(Method method)
		{
			var result = await _httpClient.GetAsync(ConfigureQuery(method));
			return await result.Content.ReadAsStringAsync();
		}
		public string GetMethodResult(Method method)
		{
			var result = _httpClient.GetAsync(ConfigureQuery(method)).Result;
			string toReturn = result.Content.ReadAsStringAsync().Result;
			return toReturn;
		}
	}
}
