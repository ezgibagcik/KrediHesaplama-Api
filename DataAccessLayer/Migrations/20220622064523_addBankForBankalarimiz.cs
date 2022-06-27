using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addBankForBankalarimiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AtmSayisi",
                table: "Bank",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EftHavale",
                table: "Bank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubeSayisi",
                table: "Bank",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtmSayisi",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "EftHavale",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "SubeSayisi",
                table: "Bank");
        }
    }
}
