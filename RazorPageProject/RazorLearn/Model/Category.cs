using System.ComponentModel.DataAnnotations;

namespace RazorLearn.Model
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Display(Name = "Name")]
		public string Name { get; set; }
		[Display(Name="Display Order")]
		public int DisplayOrder { get; set; }
	}
}
