using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Domain.Modules.Phones
{
	internal class PhoneNumberValidatorAttribute : ValidationAttribute
	{
		private readonly string _numberPatternValidate;
		private readonly string _formatPattern;

		internal PhoneNumberValidatorAttribute(string numberPatternValidate, string formatPattern = null)
		{
			_numberPatternValidate = numberPatternValidate;
			_formatPattern = formatPattern;
		}

		public override bool IsValid(object value)
		{
			string number = value as string;
			if (string.IsNullOrEmpty(number))
			{
				return false;
			}

			string formatted = string.IsNullOrEmpty(_formatPattern)
				? number
				: Regex.Replace(number, _formatPattern, "");

			if (!new Regex(_numberPatternValidate).IsMatch(formatted))
				return false;

			return true;
		}
	}
}