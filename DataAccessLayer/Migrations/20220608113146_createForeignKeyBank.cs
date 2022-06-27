using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class createForeignKeyBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "InterestRate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InterestRate_BankId",
                table: "InterestRate",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestRate_Bank_BankId",
                table: "InterestRate",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestRate_Bank_BankId",
                table: "InterestRate");

            migrationBuilder.DropIndex(
                name: "IX_InterestRate_BankId",
                table: "InterestRate");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "InterestRate");
        }
    }
}
