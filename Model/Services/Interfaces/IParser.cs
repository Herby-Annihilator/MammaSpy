using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.Services.Interfaces
{
	public interface IParser
	{
		T Parse<T>(string jsonString);
	}
}
