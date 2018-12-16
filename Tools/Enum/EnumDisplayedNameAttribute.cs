using System;

namespace Tools.Enum
{
	[AttributeUsage(AttributeTargets.Field)]
	public class EnumDisplayedNameAttribute : Attribute
	{
		public EnumDisplayedNameAttribute(string name)
		{
			Name = name;
		}

		public string Name { get; }
	}
}
