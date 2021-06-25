using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_Orderid",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProducts_Orders_StoreId",
                table: "StoreProducts");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "OrderProducts",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_Orderid",
                table: "OrderProducts",
                newName: "IX_OrderProducts_OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
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
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProducts_Stores_StoreId",
                table: "StoreProducts");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderProducts",
                newName: "Orderid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_Orderid",
                table: "OrderProducts",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProducts_Orders_StoreId",
                table: "StoreProducts",
                column: "StoreId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
