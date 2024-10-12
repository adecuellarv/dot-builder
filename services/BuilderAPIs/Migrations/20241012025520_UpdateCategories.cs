using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderAPIs.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "CategoryNameEsp");

            migrationBuilder.AddColumn<string>(
                name: "CategoryNameEn",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryNameEn",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryNameEsp",
                table: "Categories",
                newName: "CategoryName");
        }
    }
}
