using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson06.TheoryCF.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Cateegories_CategoryId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cateegories",
                table: "Cateegories");

            migrationBuilder.RenameTable(
                name: "Cateegories",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategooryName",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Cateegories");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Cateegories",
                newName: "CategooryName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cateegories",
                table: "Cateegories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Cateegories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Cateegories",
                principalColumn: "CategoryId");
        }
    }
}
