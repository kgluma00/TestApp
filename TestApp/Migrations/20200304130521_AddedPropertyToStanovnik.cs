using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApp.Migrations
{
    public partial class AddedPropertyToStanovnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stanovniks_Grads_GradId",
                table: "Stanovniks");

            migrationBuilder.AlterColumn<int>(
                name: "GradId",
                table: "Stanovniks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stanovniks_Grads_GradId",
                table: "Stanovniks",
                column: "GradId",
                principalTable: "Grads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stanovniks_Grads_GradId",
                table: "Stanovniks");

            migrationBuilder.AlterColumn<int>(
                name: "GradId",
                table: "Stanovniks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Stanovniks_Grads_GradId",
                table: "Stanovniks",
                column: "GradId",
                principalTable: "Grads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
