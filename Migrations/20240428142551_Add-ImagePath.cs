using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace simple_crud.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImagePath", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8052), "", new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImagePath", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8056), "", new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImagePath", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8059), "", new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImagePath", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8063), "", new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImagePath", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8066), "", new DateTime(2024, 4, 28, 14, 25, 50, 945, DateTimeKind.Utc).AddTicks(8066) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6094), new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6098), new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6102), new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6105), new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6109), new DateTime(2024, 4, 28, 12, 37, 59, 127, DateTimeKind.Utc).AddTicks(6109) });
        }
    }
}
