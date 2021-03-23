using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model
{
	public class Dossier
	{
		public string FirstName { get; set; } = "not found";
		public string LastName { get; set; } = "not found";
		public string Patronymic { get; set; } = "not found";
		public int Age { get; set; }
		public string Address { get; set; } = "not found";
		public string StudyPlace { get; set; } = "not found";
		public string JobPlace { get; set; } = "not found";
		public List<Friend> Friends { get; set; } = new List<Friend>();
		public string PathToPhoto { get; set; } = "";
	}
}
