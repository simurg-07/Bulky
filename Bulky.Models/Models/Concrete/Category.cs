using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bulky.Models.Models.Abstract;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace Bulky.Models.Models.Concrete;
public class Category : Base
{


	[Required]
	public string Name { get; set; }
	[DisplayName("Display Order")]
	[Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
	public int CategoryId { get; set; }
	public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    

    
    
    public string Description { get; set; }
    [ValidateNever]
    public string ImageUrl { get; set; }

	[JsonIgnore]
	public ICollection<Product> Products { get; set; }

	// bunu yazarken [JsonIgnore] bunu koymazsan hata alýrsýn




}