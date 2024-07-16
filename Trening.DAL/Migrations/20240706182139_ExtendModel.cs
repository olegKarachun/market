using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trening.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ExtendModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Addres",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addres",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customers");
        }
    }
}
