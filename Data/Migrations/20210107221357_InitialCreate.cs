using Microsoft.EntityFrameworkCore.Migrations;

namespace Faktura.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaktureProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaktureProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaktureStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaktureStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fakture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<int>(nullable: false),
                    Date = table.Column<string>(nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    FaktureProductsId = table.Column<int>(nullable: false),
                    FaktureStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fakture_FaktureProducts_FaktureProductsId",
                        column: x => x.FaktureProductsId,
                        principalTable: "FaktureProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fakture_FaktureStatus_FaktureStatusId",
                        column: x => x.FaktureStatusId,
                        principalTable: "FaktureStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fakture_FaktureProductsId",
                table: "Fakture",
                column: "FaktureProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Fakture_FaktureStatusId",
                table: "Fakture",
                column: "FaktureStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fakture");

            migrationBuilder.DropTable(
                name: "FaktureProducts");

            migrationBuilder.DropTable(
                name: "FaktureStatus");
        }
    }
}
