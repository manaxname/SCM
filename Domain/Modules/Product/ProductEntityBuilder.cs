using Tools.Enum;

namespace Domain.Modules.Product
{
	public class ProductEntityBuilder
	{
		public ProductEntity BuildProduct(DataModel.Product origin)
		{
			var product = new ProductEntity(origin.Code);
			product.Description = origin.Description;
			product.Name = origin.Name;
			var status = EnumHelper.ConvertStringToEnum<ProductStatus>(origin.Status);
			product.IsOnSale = status == ProductStatus.InStock || status == ProductStatus.ReadyToOrder ||
			                   status == ProductStatus.Sold;
			product.Status = status;
			return product;
		}

		public void SetDescription(ProductEntity product, string description)
		{
			product.Description = description;
			product.IsChanged = true;
		}

		public void SetName(ProductEntity product, string name)
		{
			product.Name = name;
			product.IsChanged = true;
		}

		public void SetStatus(ProductEntity product, ProductStatus status)
		{
			product.Status = status;
			product.IsOnSale = status == ProductStatus.InStock || status == ProductStatus.ReadyToOrder ||
			                   status == ProductStatus.Sold;
			product.IsChanged = true;
		}
	}
}