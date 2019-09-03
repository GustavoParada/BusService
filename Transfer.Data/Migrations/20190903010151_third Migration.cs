using Microsoft.EntityFrameworkCore.Migrations;

namespace Transfer.Data.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromAccountType",
                table: "TransferLog");

            migrationBuilder.DropColumn(
                name: "ToAccountType",
                table: "TransferLog");

            migrationBuilder.AddColumn<int>(
                name: "FromAccount",
                table: "TransferLog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToAccount",
                table: "TransferLog",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromAccount",
                table: "TransferLog");

            migrationBuilder.DropColumn(
                name: "ToAccount",
                table: "TransferLog");

            migrationBuilder.AddColumn<string>(
                name: "FromAccountType",
                table: "TransferLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToAccountType",
                table: "TransferLog",
                nullable: true);
        }
    }
}
