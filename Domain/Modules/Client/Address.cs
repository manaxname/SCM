using System.Collections.Generic;
using DataModel;
using Domain.General;
using Domain.General.Exceptions;

namespace Domain.Modules.Client
{
	public sealed class Address : GeneralValueObject<UserAddress>
	{
		internal Address(UserAddress value) : base(value)
		{
		}

		protected override bool IsEqualTo(IValueObject other)
		{
			if (other is Address)
				return other.GetHashCode() == GetHashCodeImpl();

			throw new InvalidCastToValueObjectException();
		}

		public override string ToString()
		{
			DataModel.Address ua = Value.Address;
			IList<string> values = new List<string>(6);
			if (!string.IsNullOrEmpty(ua.Country))
			{
				values.Add(ua.Country);
			}
			if (!string.IsNullOrEmpty(ua.State))
			{
				values.Add(ua.State);
			}
			if (!string.IsNullOrEmpty(ua.District))
			{
				values.Add(ua.District);
			}
			if (!string.IsNullOrEmpty(ua.City))
			{
				values.Add(ua.City);
			}
			if (!string.IsNullOrEmpty(ua.Street))
			{
				values.Add(ua.Street);
			}
			if (ua.NumberOfBuildings == 0)
			{
				values.Add(ua.NumberOfBuildings.ToString());
			}
			return string.Join(", ", values);
		}
	}
}