namespace Domain.General
{
	public abstract class Entity : CoreDdd.Domain.Entity
	{
		// ReSharper disable once VirtualMemberCallInConstructor
		protected Entity(int id) => Id = id;

		public bool IsChanged { get; internal set; }
	}
}
