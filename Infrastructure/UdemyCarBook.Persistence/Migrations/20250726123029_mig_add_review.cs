using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "CarFeatures",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeatures_CarID",
                table: "CarFeatures",
                newName: "IX_CarFeatures_CarId");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "CarDescriptions",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescriptions_CarID",
                table: "CarDescriptions",
                newName: "IX_CarDescriptions_CarId");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaytingValue = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CarId",
                table: "Reviews",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarId",
                table: "CarDescriptions",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarId",
                table: "CarFeatures",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarId",
                table: "CarDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarId",
                table: "CarFeatures");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "CarFeatures",
                newName: "CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeatures_CarId",
                table: "CarFeatures",
                newName: "IX_CarFeatures_CarID");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "CarDescriptions",
                newName: "CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescriptions_CarId",
                table: "CarDescriptions",
                newName: "IX_CarDescriptions_CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
