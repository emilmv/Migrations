using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Libraries_LibraryID",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Book_LibraryID",
                table: "Books",
                newName: "IX_Books_LibraryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Libraries_LibraryID",
                table: "Books",
                column: "LibraryID",
                principalTable: "Libraries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Libraries_LibraryID",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_Books_LibraryID",
                table: "Book",
                newName: "IX_Book_LibraryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Libraries_LibraryID",
                table: "Book",
                column: "LibraryID",
                principalTable: "Libraries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
