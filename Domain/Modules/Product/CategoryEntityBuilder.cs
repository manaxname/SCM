using System.Collections.Generic;
using System.Linq;

namespace Domain.Modules.Product
{
	public class CategoryEntityBuilder
	{
		public static CategoryEntity BuildCategory(DataModel.Category origin)
		{
			var entity = new CategoryEntity(origin.Id);
			SetName(entity, origin.Name);
			if (origin.ParentCategory != null)
				SetParent(entity, BuildCategory(origin.ParentCategory));
			return entity;
		}

		public static void SetName(CategoryEntity entity, string name)
		{
			entity.Name = name;
		}

		public static void SetParent(CategoryEntity entity, CategoryEntity parent)
		{
			if (parent != null && parent != entity)
			{
				entity.ParentCategory = parent;
			}
		}

		internal static void AddProductToCategory(CategoryEntity category, ProductEntity product)
		{
			if (category.Products.Contains(product))
				return;
			var newProductList = new List<ProductEntity>(category.Products.Count + 1);
			newProductList.AddRange(category.Products);
			newProductList.Add(product);
			category.Products = newProductList;
		}

		internal static void RemovePropertyFromCategory(ProductEntity product)
		{
			var products = product.Category?.Products;
			if (products == null)
				return;
			var newProductList = new List<ProductEntity>(products);
			newProductList.Remove(product);
			product.Category.Products = newProductList;
		}
	}
}