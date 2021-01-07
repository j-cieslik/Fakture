using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Faktura.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Tax = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    FaktureProductsId = table.Column<int>(nullable: false),
                    FaktureStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facture_Products_FaktureProductsId",
                        column: x => x.FaktureProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facture_Status_FaktureStatusId",
                        column: x => x.FaktureStatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facture_FaktureProductsId",
                table: "Facture",
                column: "FaktureProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Facture_FaktureStatusId",
                table: "Facture",
                column: "FaktureStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facture");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
