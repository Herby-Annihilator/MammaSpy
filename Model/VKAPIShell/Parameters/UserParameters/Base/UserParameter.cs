using MammaSpy.Model.VKAPIShell.Parameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base
{
	public abstract class UserParameter : Parameter
	{
		public override string GetStringFormat() => $"{Name}={Value}";
	}
}
