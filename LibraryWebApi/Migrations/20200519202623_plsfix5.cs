using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryWebApi.Migrations
{
    public partial class plsfix5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Users_BorrowedById",
                table: "BorrowedBooks");

            migrationBuilder.DropIndex(
                name: "IX_BorrowedBooks_BookId",
                table: "BorrowedBooks");

            migrationBuilder.DropIndex(
                name: "IX_BorrowedBooks_BorrowedById",
                table: "BorrowedBooks");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BorrowedBooks");

            migrationBuilder.DropColumn(
                name: "BorrowedById",
                table: "BorrowedBooks");

            migrationBuilder.AddColumn<string>(
                name: "BookName",
                table: "BorrowedBooks",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BookNumber",
                table: "BorrowedBooks",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ReaderName",
                table: "BorrowedBooks",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReaderNumber",
                table: "BorrowedBooks",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookName",
                table: "BorrowedBooks");

            migrationBuilder.DropColumn(
                name: "BookNumber",
                table: "BorrowedBooks");

            migrationBuilder.DropColumn(
                name: "ReaderName",
                table: "BorrowedBooks");

            migrationBuilder.DropColumn(
                name: "ReaderNumber",
                table: "BorrowedBooks");

            migrationBuilder.AddColumn<long>(
                name: "BookId",
                table: "BorrowedBooks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BorrowedById",
                table: "BorrowedBooks",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BookId",
                table: "BorrowedBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BorrowedById",
                table: "BorrowedBooks",
                column: "BorrowedById");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Users_BorrowedById",
                table: "BorrowedBooks",
                column: "BorrowedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
