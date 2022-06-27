using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AddPaymentValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AmountOfInterestPaid",
                table: "PaymentPlan",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AmountOfPrincipalPaid",
                table: "PaymentPlan",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RemainingPrincipalDebt",
                table: "PaymentPlan",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountOfInterestPaid",
                table: "PaymentPlan");

            migrationBuilder.DropColumn(
                name: "AmountOfPrincipalPaid",
                table: "PaymentPlan");

            migrationBuilder.DropColumn(
                name: "RemainingPrincipalDebt",
                table: "PaymentPlan");
        }
    }
}
