using System.Collections.Generic;
using Domain.General;

namespace Domain.Modules.Product
{
	public class CategoryEntity : Entity
	{
		public CategoryEntity(int id) : base(id)
		{
		}

		public string Name { get; internal set; }

		public CategoryEntity ParentCategory { get; internal set; }

		public IReadOnlyCollection<ProductEntity> Products { get; internal set; }
	}
}