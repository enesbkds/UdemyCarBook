using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_blog_add_Description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Cars_CarID",
                table: "CarPricings");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "CarPricings",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_CarID",
                table: "CarPricings",
                newName: "IX_CarPricings_CarId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Cars_CarId",
                table: "CarPricings",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Cars_CarId",
                table: "CarPricings");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "CarPricings",
                newName: "CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_CarId",
                table: "CarPricings",
                newName: "IX_CarPricings_CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Cars_CarID",
                table: "CarPricings",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
