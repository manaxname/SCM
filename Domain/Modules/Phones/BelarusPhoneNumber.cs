using Domain.General;
using Domain.General.Exceptions;

namespace Domain.Modules.Phones
{
	public sealed class BelarusPhoneNumber : InternationalPhoneNumber
	{
		private const string ByCode = "375";

		[PhoneNumberValidator(@"[\d]{9}", @"[^\d]")]
		internal BelarusPhoneNumber(string number) : base(
			ByCode, GetCodeFromNumber(number), GetNumberWithoutCode(number))
		{
		}

		protected override bool IsEqualTo(IValueObject other)
		{
			if (other is BelarusPhoneNumber)
			{
				return GetHashCode() == other.GetHashCode();
			}

			if (other is InternationalPhoneNumber)
			{
				return false;
			}

			throw new InvalidCastToValueObjectException();
		}

		public override string ToString()
		{
			return $"+{InternationalCode}(0{Code}){FormattedNumber(Value)}";
		}

		private static string GetCodeFromNumber(string number)
		{
			return number.Length == 7 ? number.Substring(0, 2) : number.Substring(2, 2);
		}

		private static string GetNumberWithoutCode(string number)
		{
			return number.Length == 7 ? number.Substring(2) : number.Substring(4);
		}

		private string FormattedNumber(string value)
		{
			return $"{value.Substring(0, 3)}-{value.Substring(3, 2)}-{value.Substring(5, 2)}";
		}
	}
}