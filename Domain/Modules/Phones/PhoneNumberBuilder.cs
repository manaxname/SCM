using System;

namespace Domain.Modules.Phones
{
	internal class PhoneNumberBuilder
	{
		internal InternationalPhoneNumber BuildPhoneNumber(string number, CountryPhoneCodeEnum code)
		{
			switch (code)
			{
				case CountryPhoneCodeEnum.Belarus:
					return new BelarusPhoneNumber(number);
				default:
					throw new ArgumentNullException(nameof(code));
			}
		}
	}
}
