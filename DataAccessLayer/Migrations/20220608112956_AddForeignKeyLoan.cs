using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AddForeignKeyLoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoanTypeId",
                table: "InterestRate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InterestRate_LoanTypeId",
                table: "InterestRate",
                column: "LoanTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestRate_LoanType_LoanTypeId",
                table: "InterestRate",
                column: "LoanTypeId",
                principalTable: "LoanType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestRate_LoanType_LoanTypeId",
                table: "InterestRate");

            migrationBuilder.DropIndex(
                name: "IX_InterestRate_LoanTypeId",
                table: "InterestRate");

            migrationBuilder.DropColumn(
                name: "LoanTypeId",
                table: "InterestRate");
        }
    }
}
