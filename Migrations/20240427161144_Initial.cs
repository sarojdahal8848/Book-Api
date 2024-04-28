using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace simple_crud.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(4997), "Basic of Physics", 100, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(4998) },
                    { 2, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5000), "Chemistry of Nature", 200, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5001) },
                    { 3, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5002), "Computer Programming", 300, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5003) },
                    { 4, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5005), "Mathematics", 150, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5005) },
                    { 5, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5007), "Physics of Nature", 250, new DateTime(2024, 4, 27, 16, 11, 42, 952, DateTimeKind.Utc).AddTicks(5008) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
