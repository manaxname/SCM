using System;
using Domain.General;

namespace Domain.Modules.Phones
{
	public abstract class InternationalPhoneNumber : GeneralValueObject<string>
	{
		protected readonly string InternationalCode;
		protected readonly string Code;

		protected InternationalPhoneNumber(string internationalCode, string code, string number) : base (number)
		{
			if(string.IsNullOrWhiteSpace(internationalCode))
				throw new ArgumentNullException(nameof(internationalCode));

			if (string.IsNullOrWhiteSpace(code))
				throw new ArgumentNullException(nameof(code));

			InternationalCode = internationalCode;
			Code = code;
		}

		protected override int GetHashCodeImpl()
		{
			return InternationalCode.GetHashCode() + Code.GetHashCode() + base.GetHashCode();
		}

		public override string ToString()
		{
			return $"{InternationalCode}-{Code}-{Value}";
		}


	}
}
