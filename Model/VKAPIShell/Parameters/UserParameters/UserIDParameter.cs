using MammaSpy.Model.VKAPIShell.Parameters.Interfaces;
using MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters
{
	class UserIDParameter : UserParameter<int>
	{
		public override string Name => "user_id";
	}
}
