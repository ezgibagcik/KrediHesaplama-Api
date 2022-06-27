using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AddPaymentPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstallmentAmount = table.Column<double>(type: "float", nullable: false),
                    LoanTerm = table.Column<int>(type: "int", nullable: false),
                    PaymentState = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterestRateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentPlan_InterestRate_InterestRateId",
                        column: x => x.InterestRateId,
                        principalTable: "InterestRate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_InterestRateId",
                table: "PaymentPlan",
                column: "InterestRateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentPlan");
        }
    }
}
