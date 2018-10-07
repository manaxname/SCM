using System;

namespace Domain.General.Exceptions
{
	public class InvalidCastToValueObjectException : Exception
	{
		public InvalidCastToValueObjectException() : base("The object can't be casted to ValueObject")
		{
		}
	}
}