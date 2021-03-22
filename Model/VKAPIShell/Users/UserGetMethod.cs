using MammaSpy.Model.VKAPIShell.Parameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Users
{
	public class UserGetMethod : Method
	{
		public UserGetMethod(List<Parameter> parameters) : base(parameters)
		{
		}

		public override string Name => "users.get";
	}
}
