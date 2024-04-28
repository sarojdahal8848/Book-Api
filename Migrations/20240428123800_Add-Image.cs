using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace simple_crud.Migrations
{
    /// <inheritdoc />
    public partial class AddImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(4997), new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5000), new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5002), new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5005), new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5007), new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5008) });
        }
    }
}
