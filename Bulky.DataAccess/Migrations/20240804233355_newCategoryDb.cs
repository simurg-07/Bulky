using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newCategoryDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3536), "Roman" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3557), "Bilim Kurgu" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3558), "Gizem" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3559), 4, "Fantastik" },
                    { 5, new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3560), 5, "Kişisel Gelişim" },
                    { 6, new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3562), 6, "Tarih" },
                    { 7, new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3562), 7, "Biyografi" },
                    { 8, new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3563), 8, "Klasikler" },
                    { 9, new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3564), 9, "Roman & Edebiyat" },
                    { 10, new DateTime(2024, 8, 5, 2, 33, 54, 850, DateTimeKind.Local).AddTicks(3565), 10, "Genç Yetişkin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 8, 2, 15, 53, 23, 459, DateTimeKind.Local).AddTicks(1150), "Action" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 8, 2, 15, 53, 23, 459, DateTimeKind.Local).AddTicks(1190), "SciFi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "Name" },
                values: new object[] { new DateTime(2024, 8, 2, 15, 53, 23, 459, DateTimeKind.Local).AddTicks(1200), "History" });
        }
    }
}
