namespace Domain.General
{
	public abstract class Entity : CoreDdd.Domain.Entity
	{
		public bool IsChanged { get; internal set; }
	}
}
