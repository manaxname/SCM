using Domain.General;

namespace Domain.Modules.Product
{
	public sealed class ProductEntity : Entity
	{
		internal ProductEntity(int id) : base(id)
		{
		}

		public string Name { get; internal set; }
		public string Description { get; internal set; }
		public ProductStatus Status { get; internal set; }
		public bool IsOnSale { get; internal set; }
		
	}
}
