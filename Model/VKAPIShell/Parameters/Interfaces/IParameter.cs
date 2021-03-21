using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.Interfaces
{
	public interface IParameter<T>
	{
		string Name { get;}
		T Value { get; set; }
		string GetStringFormat();
	}
}
