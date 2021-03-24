using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model
{
	public class Dossier : BaseDossier
	{
		public List<Friend> Friends { get; set; } = new List<Friend>();
		public string PathToPhoto { get; set; } = "";
	}
}
