using System;
using System.Linq;
using System.Reflection;

namespace Tools.Enum
{
	public static class EnumHelper
	{
		public static string GetDisplayedName<T>(T value) where T : struct
		{
			Type enumType = typeof(T);
			string name = value.ToString();
			FieldInfo info = enumType.GetField(name);
			EnumDisplayedNameAttribute[] attributes =
				(EnumDisplayedNameAttribute[]) info.GetCustomAttributes(typeof(EnumDisplayedNameAttribute), false);
			return attributes.Any() ? attributes.First().Name : name;
		}

		public static T ConvertStringToEnum<T>(string value) where T : struct
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentNullException(nameof(value));
			}

			if (System.Enum.TryParse(value, false, out T result))
			{
				return result;
			}

			throw new ArgumentException(nameof(value));
		}
	}
}