using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aarim_Data.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    Number = table.Column<Guid>(nullable: false),
                    CardholderName = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CardBrand = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    HasPassword = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransacationId = table.Column<Guid>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CardNumber = table.Column<Guid>(nullable: true),
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransacationId);
                    table.ForeignKey(
                        name: "FK_Transaction_CreditCard_CardNumber",
                        column: x => x.CardNumber,
                        principalTable: "CreditCard",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CardNumber",
                table: "Transaction",
                column: "CardNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "CreditCard");
        }
    }
}
