using Tools.Enum;

namespace Domain.Modules.Product
{
	public enum ProductStatus
	{
		[EnumDisplayedName("Черновик")]
		Draft = 0,
		[EnumDisplayedName("На складе")]
		InStock = 1,
		[EnumDisplayedName("Продано")]
		Sold,
		[EnumDisplayedName("Снят с производства")]
		Obsolete,
		[EnumDisplayedName("Готов к предзаказу")]
		ReadyToOrder,
		[EnumDisplayedName("Скрыт")]
		Hide
	}
}
