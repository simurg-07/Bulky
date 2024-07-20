using Bulky.Models.Config.Abstract;
using Bulky.Models.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models.Config.Concrete
{
	public class CategoryConfig : BaseConfig<Category>
	{
		public override void Configure(EntityTypeBuilder<Category> builder)
		{
			base.Configure(builder);
			builder.Property(p => p.Name).HasMaxLength(50);


          
        }
	}
}
