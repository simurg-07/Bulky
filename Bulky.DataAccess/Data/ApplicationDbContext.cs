using Bulky.Models.Models.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Bulky.DataAccess.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ApplicationUser> ApplicationbUsers { get; set; }
    public DbSet<Comment> Comments { get; set; }
	public DbSet<ShoppingCart> ShoppingCarts { get; set; }

	//macos
	//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	//{
	//	optionsBuilder.UseSqlServer(@"Server=localhost;Database=Bulky; User ID=SA;Password=reallyStrongPwd123;Trusted_Connection=false;TrustServerCertificate=true"
	// );
	//}


	//windows
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-DGN2C8I;Database=Bulky;Trusted_Connection=true;TrustServerCertificate=true"
    );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);




        var assembly = Assembly.Load("Bulky.Models");
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);


        modelBuilder.Entity<Category>().HasData(

            new Category { Id = 1, Name = "Roman", Description = "Duygusal ve heyecanlý romanlar", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 1 },
new Category { Id = 2, Name = "Bilim Kurgu", Description = "Gelecek ve teknolojik hikayeler", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 2 },
new Category { Id = 3, Name = "Gizem", Description = "Sürükleyici ve þaþýrtýcý olaylar", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 3 },
new Category { Id = 4, Name = "Fantastik", Description = "Büyülü ve fantastik dünyalar", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 4 },
new Category { Id = 5, Name = "Kiþisel Geliþim", Description = "Kiþisel geliþim ve motivasyon", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 5 },
new Category { Id = 6, Name = "Tarih", Description = "Geçmiþe dair etkileyici olaylar", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 6 },
new Category { Id = 7, Name = "Biyografi", Description = "Ünlü kiþilerin hayat öyküleri", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 7 },
new Category { Id = 8, Name = "Klasikler", Description = "Edebiyatýn baþyapýtlarý", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 8 },
new Category { Id = 9, Name = "Roman & Edebiyat", Description = "Roman ve edebiyat türleri", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 9 },
new Category { Id = 10, Name = "Genç Yetiþkin", Description = "Genç yetiþkinler için kitaplar", ImageUrl = "https://lh3.googleusercontent.com/aC9nyW5dhaYFmWD8fcf8DApjpH08eHEkbCHqmUPHRQ5T3jK-QyNKZYVMehmrvyPdEA_KxWvgZ3_kyOOYOAv99Ow3UoKSvEloleVKGSfLOwOyDV3Q6Dwi1G-NYoa9-t_ofmmskE6BYnVIOnIz2HWlMcijzIEwvKAL_R4z63DaLgG0z_OcGiSQHunwGAPXrBQUv42ZXuIMODq4zxDHczSxJ72b0-_udtdQK3JuT2X8nXCwFoF7GxmOpzXS0H5f50DuCbXoXcx-O7bgBMCXZdMpTxB27-wdXeLmxpYUySXgjSN2NAKmK16DmGLYvw5tMlrqwb8h4MJEEbXjP1pjPxXsahb7UZseEGyn80uLjATANJvusyJWCtzkkxYXPz-yI1rDvfEJKe2eyA-5AvFlzFBSwBMASn8f7mXinUrXMMREkJQjoi89NfZ91G7253OEVQOqcWxddiYtcHCO5v6Pl3QfV2SUTWXgggscDSY2ezjSPpYERNTXnIM_aCyWmIG7ybrfqOB0eVYBAgynyuPVbjd4KuZWZq2Dfu33HX1RuPKglbOuZGD1QbpJnruvUVkAmjDXI40ENN7X=w1600-h900", CategoryId = 10 }


            );


       
 modelBuilder.Entity<Product>().HasData(
    new Product
    {
        Id = 1,
        Title = "Fortune of Time",
        Author = "Billy Spark",
        Description = "Zamanýn Þansý, hayatýn sunduðu fýrsatlarý ve zorluklarý keþfetmek üzerine bir yolculuða çýkmanýzý saðlýyor. Bilgelik ve macera dolu bu kitap, yaþamýn anlamýný sorgulamanýzý saðlayacak.",
        ISBN = "SWD9999001",
        ListPrice = 99,
        Price = 90,
        Price50 = 85,
        Price100 = 80,
        CategoryId = 1,
        ImageUrl = "images/bookimages/book-1.png"
    },
    new Product
    {
        Id = 2,
        Title = "Dark Skies",
        Author = "Nancy Hoover",
        Description = "Karanlýk Gökyüzü, bilinmeyen ve gizemli bir dünyanýn kapýlarýný aralýyor. Gerilim ve heyecan dolu bu hikaye, sizi derin düþüncelere ve unutulmaz anlara sürükleyecek.",
        ISBN = "CAW777777701",
        ListPrice = 40,
        Price = 30,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 1,
        ImageUrl = "images/bookimages/book-2.png"
    },
    new Product
    {
        Id = 3,
        Title = "Vanish in the Sunset",
        Author = "Julian Button",
        Description = "Günbatýmýnda Kayboluþ, günün son ýþýklarýnda kaybolmanýn ve huzuru aramanýn öyküsünü anlatýyor. Romantik ve düþündürücü bu kitap, size güzel anýlar býrakacak.",
        ISBN = "RITO5555501",
        ListPrice = 55,
        Price = 50,
        Price50 = 40,
        Price100 = 35,
        CategoryId = 1,
        ImageUrl = "images/bookimages/book-3.png"
    },
    new Product
    {
        Id = 4,
        Title = "Cotton Candy",
        Author = "Abby Muscles",
        Description = "Pamuk Þeker, yaþamýn tatlý ve hafif yanlarýný keþfetmenizi saðlýyor. Eðlenceli ve keyifli bir okuma deneyimi sunan bu kitap, günlük yaþamýn stresinden uzaklaþmanýza yardýmcý olacak.",
        ISBN = "WS3333333301",
        ListPrice = 70,
        Price = 65,
        Price50 = 60,
        Price100 = 55,
        CategoryId = 2,
        ImageUrl = "images/bookimages/book-4.png"
    },
    new Product
    {
        Id = 5,
        Title = "Rock in the Ocean",
        Author = "Ron Parker",
        Description = "Okyanustaki Kaya, denizin derinliklerinde geçen bir macerayý anlatýyor. Doða ve denizle iç içe bir serüven arýyorsanýz, bu kitap tam size göre.",
        ISBN = "SOTJ1111111101",
        ListPrice = 30,
        Price = 27,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 3,
        ImageUrl = "images/bookimages/book-5.png"
    },
    new Product
    {
        Id = 6,
        Title = "Leaves and Wonders",
        Author = "Laura Phantom",
        Description = "Yapraklar ve Harikalar, doðanýn güzelliklerini ve keþfedilmemiþ sýrlarýný anlatýyor. Þiirsel anlatýmý ve göz alýcý betimlemeleri ile sizi büyüleyecek.",
        ISBN = "FOT000000001",
        ListPrice = 25,
        Price = 23,
        Price50 = 22,
        Price100 = 20,
        CategoryId = 2,
        ImageUrl = "images/bookimages/book-6.png"
    },
    new Product
    {
        Id = 7,
        Title = "Mystic River",
        Author = "Tom Hardy",
        Description = "Gizemli Nehir, doðanýn ve tarihin iç içe geçtiði bir anlatý sunuyor. Derin bir keþif ve tarih yolculuðu yapmak isteyenler için ideal bir kitap.",
        ISBN = "MR1234567890",
        ListPrice = 45,
        Price = 40,
        Price50 = 35,
        Price100 = 30,
        CategoryId = 1,
        ImageUrl = "images/bookimages/book-7.png"
    },
    new Product
    {
        Id = 8,
        Title = "Moonlight Shadows",
        Author = "Lily Collins",
        Description = "Ay Iþýðýnda Gölgeler, gece ve mistisizmin iç içe geçtiði bir öyküyü anlatýyor. Gizemli ve etkileyici bir okuma deneyimi arýyorsanýz, bu kitap size hitap edecek.",
        ISBN = "MS0987654321",
        ListPrice = 60,
        Price = 55,
        Price50 = 50,
        Price100 = 45,
        CategoryId = 1,
        ImageUrl = "images/bookimages/book-8.png"
    },
    new Product
    {
        Id = 9,
        Title = "Golden Sands",
        Author = "Chris Evans",
        Description = "Altýn Kumlar, tatil ve rahatlama arayýþýndaki bir karakterin hikayesini sunuyor. Sýcak kumsallar ve huzur dolu anlar için ideal bir okuma.",
        ISBN = "GS2345678901",
        ListPrice = 80,
        Price = 75,
        Price50 = 70,
        Price100 = 65,
        CategoryId = 2,
        ImageUrl = "images/bookimages/book-9.png"
    },
    new Product
    {
        Id = 10,
        Title = "Whispering Pines",
        Author = "Emma Watson",
        Description = "Fýsýldayan Çamlar, doða ve huzur arayanlar için etkileyici bir hikaye sunuyor. Doðanýn sessizliði ve güzelliði hakkýnda derin bir düþünce.",
        ISBN = "WP3456789012",
        ListPrice = 35,
        Price = 30,
        Price50 = 28,
        Price100 = 25,
        CategoryId = 3,
        ImageUrl = "images/bookimages/book-10.png"
    },
    new Product
    {
        Id = 11,
        Title = "Sunset Dreams",
        Author = "Robert Downey Jr.",
        Description = "Günbatýmý Rüyalarý, günün son ýþýklarýnýn oluþturduðu atmosferi ve umut dolu bir geleceði keþfetmenizi saðlýyor. Huzur verici ve düþündürücü bir deneyim.",
        ISBN = "SD4567890123",
        ListPrice = 55,
        Price = 50,
        Price50 = 45,
        Price100 = 40,
        CategoryId = 1,
        ImageUrl = "images/bookimages/book-11.png"
    },
    new Product
    {
        Id = 12,
        Title = "Ocean Breeze",
        Author = "Scarlett Johansson",
        Description = "Okyanus Esintisi, denizin ferahlýðýný ve huzurunu yansýtýyor. Rahatlatýcý ve tazeleyici bir okuma deneyimi arayanlar için ideal bir seçim.",
        ISBN = "OB5678901234",
        ListPrice = 70,
        Price = 65,
        Price50 = 60,
        Price100 = 55,
        CategoryId = 2,
        ImageUrl = "images/bookimages/book-12.png"
    },
    new Product
    {
        Id = 13,
        Title = "Winter's Tale",
        Author = "Chris Hemsworth",
        Description = "Kýþ Masalý, karanlýk ve soðuk kýþ günlerinde geçen bir öyküyü anlatýyor. Kýþýn derinliklerine dair etkileyici ve sürükleyici bir deneyim.",
        ISBN = "WT6789012345",
        ListPrice = 40,
        Price = 35,
        Price50 = 30,
        Price100 = 25,
        CategoryId = 3,
        ImageUrl = "images/bookimages/book-13.png"
    },
    new Product
    {
        Id = 14,
        Title = "Spring Blossoms",
        Author = "Gal Gadot",
        Description = "Ýlkbahar Çiçekleri, doðanýn uyanýþýný ve taze baþlangýçlarý anlatýyor. Baharýn canlýlýðý ve enerjisini hissetmek isteyenler için ideal bir okuma.",
        ISBN = "SB7890123456",
        ListPrice = 65,
        Price = 60,
        Price50 = 55,
        Price100 = 50,
        CategoryId = 2,
        ImageUrl = "images/bookimages/book-14.png"
    },
    new Product
    {
        Id = 15,
        Title = "Autumn Leaves",
        Author = "Jason Momoa",
        Description = "Sonbahar Yapraklarý, mevsimlerin deðiþimi ve yaþamýn döngüsü hakkýnda derin bir düþünce sunuyor. Sonbaharýn güzelliðini ve melankolisini yansýtan etkileyici bir hikaye.",
        ISBN = "AL8901234567",
        ListPrice = 30,
        Price = 28,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 1,
        ImageUrl = "images/bookimages/book-15.png"
    });

        modelBuilder.Entity<Comment>().HasData(
          new Comment
          {
              Id = 1, // Yorum ID'si, gerekli ise ayarlayýn
              Content = "Bu kitabý çok sevdim! Julian Button'ýn kalemi harika ve hikaye çok sürükleyici.",
              CreatedAt = DateTime.Now,
              Author = "Emily",
              ProductId = 3
          },
          new Comment
          {
              Id = 2, // Yorum ID'si, gerekli ise ayarlayýn
              Content = "Çok keyifli bir okuma deneyimiydi. Kitap beni derinden etkiledi.",
              CreatedAt = DateTime.Now,
              Author = "James",
              ProductId = 3
          },
          new Comment
          {
              Id = 3, // Yorum ID'si, gerekli ise ayarlayýn
              Content = "Julian Button'ýn en iyi kitaplarýndan biri. Kesinlikle tavsiye ederim!",
              CreatedAt = DateTime.Now,
              Author = "Sarah",
              ProductId = 3
          }
      );



    }


}
