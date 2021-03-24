using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Users
{
	public class UserResponce<T>
	{
		public IList<T> response { get; set; }
	}
}
