using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newMgDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 20, 5, 51, 32, 578, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Zamanın Şansı, hayatın sunduğu fırsatları ve zorlukları keşfetmek üzerine bir yolculuğa çıkmanızı sağlıyor. Bilgelik ve macera dolu bu kitap, yaşamın anlamını sorgulamanızı sağlayacak.", "images/bookimages/book-1.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Karanlık Gökyüzü, bilinmeyen ve gizemli bir dünyanın kapılarını aralıyor. Gerilim ve heyecan dolu bu hikaye, sizi derin düşüncelere ve unutulmaz anlara sürükleyecek.", "images/bookimages/book-2.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Günbatımında Kayboluş, günün son ışıklarında kaybolmanın ve huzuru aramanın öyküsünü anlatıyor. Romantik ve düşündürücü bu kitap, size güzel anılar bırakacak.", "images/bookimages/book-3.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Pamuk Şeker, yaşamın tatlı ve hafif yanlarını keşfetmenizi sağlıyor. Eğlenceli ve keyifli bir okuma deneyimi sunan bu kitap, günlük yaşamın stresinden uzaklaşmanıza yardımcı olacak.", "images/bookimages/book-4.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Okyanustaki Kaya, denizin derinliklerinde geçen bir macerayı anlatıyor. Doğa ve denizle iç içe bir serüven arıyorsanız, bu kitap tam size göre.", "images/bookimages/book-5.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Yapraklar ve Harikalar, doğanın güzelliklerini ve keşfedilmemiş sırlarını anlatıyor. Şiirsel anlatımı ve göz alıcı betimlemeleri ile sizi büyüleyecek.", "images/bookimages/book-6.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Gizemli Nehir, doğanın ve tarihin iç içe geçtiği bir anlatı sunuyor. Derin bir keşif ve tarih yolculuğu yapmak isteyenler için ideal bir kitap.", "images/bookimages/book-7.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Ay Işığında Gölgeler, gece ve mistisizmin iç içe geçtiği bir öyküyü anlatıyor. Gizemli ve etkileyici bir okuma deneyimi arıyorsanız, bu kitap size hitap edecek.", "images/bookimages/book-8.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Altın Kumlar, tatil ve rahatlama arayışındaki bir karakterin hikayesini sunuyor. Sıcak kumsallar ve huzur dolu anlar için ideal bir okuma.", "images/bookimages/book-9.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Fısıldayan Çamlar, doğa ve huzur arayanlar için etkileyici bir hikaye sunuyor. Doğanın sessizliği ve güzelliği hakkında derin bir düşünce.", "images/bookimages/book-10.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Günbatımı Rüyaları, günün son ışıklarının oluşturduğu atmosferi ve umut dolu bir geleceği keşfetmenizi sağlıyor. Huzur verici ve düşündürücü bir deneyim.", "images/bookimages/book-11.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Okyanus Esintisi, denizin ferahlığını ve huzurunu yansıtıyor. Rahatlatıcı ve tazeleyici bir okuma deneyimi arayanlar için ideal bir seçim.", "images/bookimages/book-12.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Kış Masalı, karanlık ve soğuk kış günlerinde geçen bir öyküyü anlatıyor. Kışın derinliklerine dair etkileyici ve sürükleyici bir deneyim.", "images/bookimages/book-13.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "İlkbahar Çiçekleri, doğanın uyanışını ve taze başlangıçları anlatıyor. Baharın canlılığı ve enerjisini hissetmek isteyenler için ideal bir okuma.", "images/bookimages/book-14.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Sonbahar Yaprakları, mevsimlerin değişimi ve yaşamın döngüsü hakkında derin bir düşünce sunuyor. Sonbaharın güzelliğini ve melankolisini yansıtan etkileyici bir hikaye.", "images/bookimages/book-15.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 20, 58, 55, 525, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "" });
        }
    }
}
