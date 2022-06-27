using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migIptalFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlan_InterestRate_InterestRateId",
                table: "PaymentPlan");

            migrationBuilder.DropIndex(
                name: "IX_PaymentPlan_InterestRateId",
                table: "PaymentPlan");

            migrationBuilder.DropColumn(
                name: "InterestRateId",
                table: "PaymentPlan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InterestRateId",
                table: "PaymentPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_InterestRateId",
                table: "PaymentPlan",
                column: "InterestRateId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlan_InterestRate_InterestRateId",
                table: "PaymentPlan",
                column: "InterestRateId",
                principalTable: "InterestRate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
