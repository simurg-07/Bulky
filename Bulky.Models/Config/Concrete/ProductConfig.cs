﻿using Bulky.Models.Config.Abstract;
using Bulky.Models.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

public class ProductConfig : BaseConfig<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);

        builder.Property(p => p.Title).HasMaxLength(50);

        builder.Property(p => p.Description).HasMaxLength(1000);
        builder.Property(p => p.ISBN).HasMaxLength(50);
        builder.Property(p => p.Author).HasMaxLength(50);

       

        builder.HasData(
    new Product
    {
        Id = 1,
        Title = "Fortune of Time",
        Author = "Billy Spark",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "SWD9999001",
        ListPrice = 99,
        Price = 90,
        Price50 = 85,
        Price100 = 80,
        CategoryId = 1,
        ImageUrl = ""
    },
    new Product
    {
        Id = 2,
        Title = "Dark Skies",
        Author = "Nancy Hoover",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "CAW777777701",
        ListPrice = 40,
        Price = 30,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 1,
        ImageUrl = ""
    },
    new Product
    {
        Id = 3,
        Title = "Vanish in the Sunset",
        Author = "Julian Button",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "RITO5555501",
        ListPrice = 55,
        Price = 50,
        Price50 = 40,
        Price100 = 35,
        CategoryId = 1,
        ImageUrl = ""
    },
    new Product
    {
        Id = 4,
        Title = "Cotton Candy",
        Author = "Abby Muscles",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "WS3333333301",
        ListPrice = 70,
        Price = 65,
        Price50 = 60,
        Price100 = 55,
        CategoryId = 2,
        ImageUrl = ""
    },
    new Product
    {
        Id = 5,
        Title = "Rock in the Ocean",
        Author = "Ron Parker",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "SOTJ1111111101",
        ListPrice = 30,
        Price = 27,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 3,
        ImageUrl = ""
    },
    new Product
    {
        Id = 6,
        Title = "Leaves and Wonders",
        Author = "Laura Phantom",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "FOT000000001",
        ListPrice = 25,
        Price = 23,
        Price50 = 22,
        Price100 = 20,
        CategoryId = 2,
        ImageUrl = ""
    },
    new Product
    {
        Id = 7,
        Title = "Mystic River",
        Author = "Tom Hardy",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "MR1234567890",
        ListPrice = 45,
        Price = 40,
        Price50 = 35,
        Price100 = 30,
        CategoryId = 1,
        ImageUrl = ""
    },
    new Product
    {
        Id = 8,
        Title = "Moonlight Shadows",
        Author = "Lily Collins",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "MS0987654321",
        ListPrice = 60,
        Price = 55,
        Price50 = 50,
        Price100 = 45,
        CategoryId = 1,
        ImageUrl = ""
    },
    new Product
    {
        Id = 9,
        Title = "Golden Sands",
        Author = "Chris Evans",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "GS2345678901",
        ListPrice = 80,
        Price = 75,
        Price50 = 70,
        Price100 = 65,
        CategoryId = 2,
        ImageUrl = ""
    },
    new Product
    {
        Id = 10,
        Title = "Whispering Pines",
        Author = "Emma Watson",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "WP3456789012",
        ListPrice = 35,
        Price = 30,
        Price50 = 28,
        Price100 = 25,
        CategoryId = 3,
        ImageUrl = ""
    },
    new Product
    {
        Id = 11,
        Title = "Sunset Dreams",
        Author = "Robert Downey Jr.",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "SD4567890123",
        ListPrice = 55,
        Price = 50,
        Price50 = 45,
        Price100 = 40,
        CategoryId = 1,
        ImageUrl = ""
    },
    new Product
    {
        Id = 12,
        Title = "Ocean Breeze",
        Author = "Scarlett Johansson",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "OB5678901234",
        ListPrice = 70,
        Price = 65,
        Price50 = 60,
        Price100 = 55,
        CategoryId = 2,
        ImageUrl = ""
    },
    new Product
    {
        Id = 13,
        Title = "Winter's Tale",
        Author = "Chris Hemsworth",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "WT6789012345",
        ListPrice = 40,
        Price = 35,
        Price50 = 30,
        Price100 = 25,
        CategoryId = 3,
        ImageUrl = ""
    },
    new Product
    {
        Id = 14,
        Title = "Spring Blossoms",
        Author = "Gal Gadot",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "SB7890123456",
        ListPrice = 65,
        Price = 60,
        Price50 = 55,
        Price100 = 50,
        CategoryId = 2,
        ImageUrl = ""
    },
    new Product
    {
        Id = 15,
        Title = "Autumn Leaves",
        Author = "Jason Momoa",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
        ISBN = "AL8901234567",
        ListPrice = 30,
        Price = 28,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 1,
        ImageUrl = ""
    });
    }
}
