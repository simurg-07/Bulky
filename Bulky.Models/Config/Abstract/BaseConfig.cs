using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulky.Models.Models.Abstract;

namespace Bulky.Models.Config.Abstract
{
	public abstract class BaseConfig<T> : IEntityTypeConfiguration<T>
		where T : Base
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{
			builder.HasKey(e => e.Id);

		}
	}
}
