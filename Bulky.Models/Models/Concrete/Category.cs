using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bulky.Models.Models.Abstract;

namespace Bulky.Models.Models.Concrete;
public class Category : Base
{


	[Required]
	public string Name { get; set; }
	[DisplayName("Display Order")]
	[Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
	public int DisplayOrder { get; set; }
	public DateTime CreatedDateTime { get; set; } = DateTime.Now;
	//public ICollection<Product>? Products { get; set; }

	// nedenini bilmiyorum ama yukarýsý aktif olduðunda datatables api çalýþmýyor
}