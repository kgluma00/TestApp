using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApp.Migrations
{
    public partial class FixedStanovnikEntityWithRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stanovnik_Grads_GradId",
                table: "Stanovnik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stanovnik",
                table: "Stanovnik");

            migrationBuilder.RenameTable(
                name: "Stanovnik",
                newName: "Stanovniks");

            migrationBuilder.RenameIndex(
                name: "IX_Stanovnik_GradId",
                table: "Stanovniks",
                newName: "IX_Stanovniks_GradId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stanovniks",
                table: "Stanovniks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stanovniks_Grads_GradId",
                table: "Stanovniks",
                column: "GradId",
                principalTable: "Grads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stanovniks_Grads_GradId",
                table: "Stanovniks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stanovniks",
                table: "Stanovniks");

            migrationBuilder.RenameTable(
                name: "Stanovniks",
                newName: "Stanovnik");

            migrationBuilder.RenameIndex(
                name: "IX_Stanovniks_GradId",
                table: "Stanovnik",
                newName: "IX_Stanovnik_GradId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stanovnik",
                table: "Stanovnik",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stanovnik_Grads_GradId",
                table: "Stanovnik",
                column: "GradId",
                principalTable: "Grads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
