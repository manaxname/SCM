using Domain.General;
using Domain.General.Exceptions;

namespace Domain.Modules.Client
{
	public sealed class Email : GeneralValueObject<string>
	{
		internal Email(string email) : base(email)
		{
		}

		protected override bool IsEqualTo(IValueObject other)
		{
			if (other is Email)
			{
				return other.ToString() == Value;
			}

			throw new InvalidCastToValueObjectException();
		}
	}
}