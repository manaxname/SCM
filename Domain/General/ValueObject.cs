using Domain.General.Exceptions;

namespace Domain.General
{
	public abstract class ValueObject<T> : IValueObject
	{
		protected abstract bool IsEqualTo(IValueObject other);
		protected abstract int GetHashCodeImpl();

		public override bool Equals(object obj)
		{
			if (!(obj is IValueObject other))
				throw new InvalidCastToValueObjectException();
			return IsEqualTo(other);
		}

		public override int GetHashCode()
		{
			/*
				int hash = 13;
				hash = (hash * 7) + field1.GetHashCode();
				hash = (hash * 7) + field2.GetHashCode();
				...
				return hash;
			 */
			return GetHashCodeImpl();
		}

		public override string ToString()
		{
			return nameof(ValueObject<T>);
		}
	}
}