using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class migration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StoreProducts_ProductId",
                table: "StoreProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProducts_StoreId",
                table: "StoreProducts",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProducts_Products_ProductId",
                table: "StoreProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProducts_Stores_StoreId",
                table: "StoreProducts",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreProducts_Products_ProductId",
                table: "StoreProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProducts_Stores_StoreId",
                table: "StoreProducts");

            migrationBuilder.DropIndex(
                name: "IX_StoreProducts_ProductId",
                table: "StoreProducts");

            migrationBuilder.DropIndex(
                name: "IX_StoreProducts_StoreId",
                table: "StoreProducts");
        }
    }
}
