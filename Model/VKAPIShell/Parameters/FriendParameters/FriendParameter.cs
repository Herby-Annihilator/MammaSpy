using MammaSpy.Model.VKAPIShell.Parameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.FriendParameters
{
	public abstract class FriendParameter : Parameter
	{
		public override string GetStringFormat() => $"{Name}={Value}";
	}
}
