using System;

namespace Domain.General
{
	public abstract class GeneralValueObject<T> : ValueObject<T>
	{
		protected readonly T Value;

		internal GeneralValueObject(T value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			Value = value;
		}

		protected override int GetHashCodeImpl()
		{
			return Value.GetHashCode();
		}

		public override string ToString()
		{
			return Value.ToString();
		}

		public static implicit operator string(GeneralValueObject<T> obj)
		{
			return obj.ToString();
		}
	}
}