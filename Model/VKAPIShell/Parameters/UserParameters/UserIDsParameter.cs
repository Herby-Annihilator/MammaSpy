using MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters
{
	public class UserIDsParameter : UserParameter
	{
		public override string Name => "user_ids";
		public UserIDsParameter(List<UserID> ids)
		{
			Value = "";
			foreach (var id in ids)
			{
				Value += id.ToString() + ",";
			}
			Value = Value.Remove(Value.Length - 1);
		}
	}

	public class UserID
	{
		private int _id;
		private string _screenName;
		public UserID(int id)
		{
			_id = id;
			_screenName = "";
		}

		public UserID(string screenName)
		{
			_screenName = screenName;
			_id = 0;
		}

		public override string ToString()
		{
			if (_screenName == "" && _id > 0) return _id.ToString();
			return _screenName;
		}
	}
}
