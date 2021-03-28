using MammaSpy.Model.VKAPIShell.Parameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Methods
{
	public abstract class Method
	{
		public abstract string Name { get; }
		public List<Parameter> Parameters { get; set; }
		public string GenerateQueryString()
		{
			string queryPart = Name + "?";
			foreach (var param in Parameters)
			{
				queryPart += param.GetStringFormat() + "&";
			}
			return queryPart;
		}
		public Method(List<Parameter> parameters)
		{
			Parameters = parameters;
		}
	}
}
