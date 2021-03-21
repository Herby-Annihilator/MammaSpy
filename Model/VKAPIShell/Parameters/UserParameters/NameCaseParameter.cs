using MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters
{
	internal class NameCaseParameter : UserParameter<NameCase>
	{
		internal NameCaseParameter()
		{
			value = NameCase.Nominative;
		}
		public override string Name => "name_case";
		public override string GetStringFormat() => $"{Name}={Value.NamseCaseStringFormat()}";
	}

	internal enum NameCase
	{
		Nominative,
		Genitive,
		Dative,
		Accusative,
		Instrumental,
		Prepositional,
	}
	internal static class NameCaseExtension
	{
		internal static string NamseCaseStringFormat(this NameCase nameCase)
		{
			return nameCase switch
			{
				NameCase.Nominative => "nom",
				NameCase.Genitive => "gen",
				NameCase.Dative => "dat",
				NameCase.Accusative => "acc",
				NameCase.Instrumental => "ins",
				NameCase.Prepositional => "abl",
				_ => "nom"
			};
		}
	}
}
