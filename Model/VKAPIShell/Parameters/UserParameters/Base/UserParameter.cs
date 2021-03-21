using MammaSpy.Model.VKAPIShell.Parameters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MammaSpy.Model.VKAPIShell.Parameters.UserParameters.Base
{
	internal abstract class UserParameter<T> : IParameter<T>
	{
		public abstract string Name { get; }
		protected T value;
		public T Value { get => value; set => this.value = value; }

		public virtual string GetStringFormat() => $"{Name}={Value}";
	}
}
