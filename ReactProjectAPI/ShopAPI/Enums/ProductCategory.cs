using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Enums
{
	public enum ProductCategory
	{
		[Display(Name = "Mobile & Tablets")]
		MobileAndTablets,
		[Display(Name = "Electronics")]
		Electronics,
		[Display(Name = "Fashion")]
		Fashion,
		[Display(Name = "Beauty")]
		Beauty,
		[Display(Name = "Home & Kitchen")]
		HomeAndKitchen,
		[Display(Name = "Furniture")]
		Furniture,
		[Display(Name = "Grocery")]
		Grocery,
		Others
	}
}
