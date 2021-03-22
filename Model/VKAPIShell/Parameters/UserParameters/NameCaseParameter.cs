using MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters
{
	public class NameCaseParameter : UserParameter
	{
		public NameCaseParameter(NameCase nameCase)
		{
			Value = nameCase.NamseCaseStringFormat();
		}
		public override string Name => "name_case";
	}

	public enum NameCase
	{
		Nominative,
		Genitive,
		Dative,
		Accusative,
		Instrumental,
		Prepositional,
	}
	public static class NameCaseExtension
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
