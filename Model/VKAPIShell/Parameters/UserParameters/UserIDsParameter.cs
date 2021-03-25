using MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters
{
	public class UserIDsParameter : UserParameter
	{
		public override string Name => "user_ids";
		public UserIDsParameter(List<int> ids)
		{
			Value = "";
			foreach (var id in ids)
			{
				Value += id.ToString() + ",";
			}
			Value = Value.Remove(Value.Length - 1);
		}
	}
}
