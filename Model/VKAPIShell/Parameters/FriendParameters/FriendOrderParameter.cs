using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.FriendParameters
{
	public class FriendOrderParameter : FriendParameter
	{
		public FriendOrderParameter(Order order)
		{
			Value = order.ToString();
		}
		public override string Name => "order";
	}

	public enum Order : uint
	{
		hints,
		random,
		name,
		count
	}
}
