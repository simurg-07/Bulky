using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class db12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShoppingCartId" },
                values: new object[] { new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(7471), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShoppingCartId" },
                values: new object[] { new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(7484), null });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShoppingCartId" },
                values: new object[] { new DateTime(2024, 8, 19, 20, 56, 23, 992, DateTimeKind.Local).AddTicks(7488), null });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ShoppingCartId",
                table: "Comments",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ShoppingCarts_ShoppingCartId",
                table: "Comments",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ShoppingCarts_ShoppingCartId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ShoppingCartId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 19, 15, 59, 4, 867, DateTimeKind.Local).AddTicks(6829));
        }
    }
}
