using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    { 1, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4407), "Basic of Physics", 100m, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4408) },
                    { 2, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4409), "Chemistry of Nature", 200m, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4409) },
                    { 3, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4411), "Computer Programming", 300m, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4411) },
                    { 4, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4412), "Mathematics", 150m, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4413) },
                    { 5, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4414), "Physics of Nature", 250m, new DateTime(2024, 4, 20, 15, 1, 44, 240, DateTimeKind.Utc).AddTicks(4415) }
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
