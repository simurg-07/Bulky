﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Bulky.Models.Models.Abstract;

namespace Bulky.Models.Models.Concrete
{
    public class Product : Base
    {
		
		public string Title { get; set; }
		public string Description { get; set; }
		[Required]
		public string ISBN { get; set; }
		[Required]
		public string Author { get; set; }
		[Required]
		[Range(1, 10000)]
		[Display(Name = "List Price")]
		public double ListPrice { get; set; }
		[Required]
		[Range(1, 10000)]
		[Display(Name = "Price for 1-50")]
		public double Price { get; set; }

		[Required]
		[Range(1, 10000)]
		[Display(Name = "Price for 51-100")]
		public double Price50 { get; set; }

		[Required]
		[Display(Name = "Price for 100+")]
		[Range(1, 10000)]
		public double Price100 { get; set; }
		[ValidateNever]
		public string ImageUrl { get; set; }

		[Required]
		[Display(Name = "Category")]
		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
		[ValidateNever]
		public Category Category { get; set; }

        [ValidateNever]
        public ICollection<Comment> Comments { get; set; }




    }
}
