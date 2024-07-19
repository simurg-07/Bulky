using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bulky.Models.Models.Abstract;

namespace Bulky.Models.Models.Concrete;
public class Category : Base
{

   
    public string Name { get; set; }
   
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

   // public ICollection<Product> Products { get; set; }
}