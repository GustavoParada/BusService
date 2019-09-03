using Microsoft.EntityFrameworkCore.Migrations;

namespace Transfer.Data.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountType",
                table: "TransferLog",
                newName: "ToAccountType");

            migrationBuilder.RenameColumn(
                name: "AccountBalance",
                table: "TransferLog",
                newName: "TransferAmount");

            migrationBuilder.AddColumn<string>(
                name: "FromAccountType",
                table: "TransferLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromAccountType",
                table: "TransferLog");

            migrationBuilder.RenameColumn(
                name: "TransferAmount",
                table: "TransferLog",
                newName: "AccountBalance");

            migrationBuilder.RenameColumn(
                name: "ToAccountType",
                table: "TransferLog",
                newName: "AccountType");
        }
    }
}
