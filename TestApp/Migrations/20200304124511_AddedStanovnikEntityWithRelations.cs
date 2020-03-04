using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApp.Migrations
{
    public partial class AddedStanovnikEntityWithRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stanovnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImeStanovnika = table.Column<string>(nullable: false),
                    PrezimeStanovnika = table.Column<string>(nullable: false),
                    UlicaStanovnika = table.Column<string>(nullable: true),
                    DatumRodenja = table.Column<DateTime>(type: "Date", nullable: false),
                    GradId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanovnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stanovnik_Grads_GradId",
                        column: x => x.GradId,
                        principalTable: "Grads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stanovnik_GradId",
                table: "Stanovnik",
                column: "GradId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stanovnik");
        }
    }
}
