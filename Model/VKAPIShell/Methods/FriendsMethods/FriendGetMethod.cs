using MammaSpy.Model.VKAPIShell.Parameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Methods.FriendsMethods
{
	public class FriendGetMethod : Method
	{
		public FriendGetMethod(List<Parameter> parameters) : base(parameters)
		{
		}

		public override string Name => "friends.get";
	}
}
