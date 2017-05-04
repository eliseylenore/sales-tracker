using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SalesTracker.Migrations
{
    public partial class SetForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSales_Cars_CarId",
                table: "CarSales");

            migrationBuilder.DropIndex(
                name: "IX_CarSales_CarId",
                table: "CarSales");

            migrationBuilder.AlterColumn<int>(
                name: "CarSaleId",
                table: "CarSales",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_CarSaleId",
                table: "CarSales",
                column: "CarSaleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarSales_Cars_CarSaleId",
                table: "CarSales",
                column: "CarSaleId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSales_Cars_CarSaleId",
                table: "CarSales");

            migrationBuilder.DropIndex(
                name: "IX_CarSales_CarSaleId",
                table: "CarSales");

            migrationBuilder.AlterColumn<int>(
                name: "CarSaleId",
                table: "CarSales",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_CarId",
                table: "CarSales",
                column: "CarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarSales_Cars_CarId",
                table: "CarSales",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
