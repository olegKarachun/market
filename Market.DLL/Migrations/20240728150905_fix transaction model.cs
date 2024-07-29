using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fixtransactionmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Customers_CustomersId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Products_ProductsId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "Transactions",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "CustomersId",
                table: "Transactions",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_ProductsId",
                table: "Transactions",
                newName: "IX_Transactions_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CustomersId",
                table: "Transactions",
                newName: "IX_Transactions_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Customers_CustomerId",
                table: "Transactions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Products_ProductId",
                table: "Transactions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Customers_CustomerId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Products_ProductId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Transactions",
                newName: "ProductsId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Transactions",
                newName: "CustomersId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_ProductId",
                table: "Transactions",
                newName: "IX_Transactions_ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CustomerId",
                table: "Transactions",
                newName: "IX_Transactions_CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Customers_CustomersId",
                table: "Transactions",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Products_ProductsId",
                table: "Transactions",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
