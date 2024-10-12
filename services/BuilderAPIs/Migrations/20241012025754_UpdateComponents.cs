using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderAPIs.Migrations
{
    /// <inheritdoc />
    public partial class UpdateComponents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComponentName",
                table: "Components",
                newName: "ComponentNameEsp");

            migrationBuilder.AddColumn<string>(
                name: "ComponentNameEn",
                table: "Components",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComponentNameEn",
                table: "Components");

            migrationBuilder.RenameColumn(
                name: "ComponentNameEsp",
                table: "Components",
                newName: "ComponentName");
        }
    }
}
