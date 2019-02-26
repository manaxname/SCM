using System.Collections.Generic;

namespace Tools.Extensions
{
	public static class StringExtensions
	{
		public static bool IsEmpty(this string origin)
		{
			return string.IsNullOrEmpty(origin);
		}

		public static string Union(this IEnumerable<string> array, string separator)
		{
			return string.Join(separator, array);
		}

		public static string Format(this string origin, string substitute, params string[] substitutes)
		{
			return string.Format(origin, substitute, substitutes);
		}
	}
}
