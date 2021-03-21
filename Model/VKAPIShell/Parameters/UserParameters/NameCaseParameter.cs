using MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters
{
	internal class NameCaseParameter : UserParameter<NameCase>
	{
		public override string Name => "name_case";
	}

	internal class NameCase
	{
		public const string Nominative = "nom";
		public const string Genitive = "gen";
		public const string Dative = "dat";
		public const string Accusative = "acc";
		public const string Instrumental = "ins";
		public const string Prepositional = "abl";
	}
}
