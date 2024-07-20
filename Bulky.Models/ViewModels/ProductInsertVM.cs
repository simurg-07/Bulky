using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models.ViewModels
{
	public class ProductInsertVM
	{
		[MaxLength(50,ErrorMessage ="lkdkladskjl")]
        public string Title { get; set; }
		public string Description { get; set; }
    }
}
