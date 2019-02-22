using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aarim_Data.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_CreditCard_CardNumber",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CardNumber",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Transaction");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "CreditCard",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "CreditCardId",
                table: "CreditCard",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_Number",
                table: "Transaction",
                column: "Number");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_CreditCard_Number",
                table: "Transaction",
                column: "Number",
                principalTable: "CreditCard",
                principalColumn: "Number",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_CreditCard_Number",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_Number",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "CreditCardId",
                table: "CreditCard");

            migrationBuilder.AddColumn<Guid>(
                name: "CardNumber",
                table: "Transaction",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Number",
                table: "CreditCard",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CardNumber",
                table: "Transaction",
                column: "CardNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_CreditCard_CardNumber",
                table: "Transaction",
                column: "CardNumber",
                principalTable: "CreditCard",
                principalColumn: "Number",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
