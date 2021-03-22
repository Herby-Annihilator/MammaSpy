using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.Base
{
	public abstract class Parameter
	{
		public virtual string Name { get;}
		public virtual string Value { get; set; }
		public abstract string GetStringFormat();
	}
}
