using Bulky.Models.Config.Abstract;
using Bulky.Models.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

public class ProductConfig : BaseConfig<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);

        builder.Property(p => p.Title).HasMaxLength(51);

        builder.Property(p => p.Description).HasMaxLength(1000);
        builder.Property(p => p.ISBN).HasMaxLength(50);
        builder.Property(p => p.Author).HasMaxLength(50);

       

       
    }
}
