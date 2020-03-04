using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApp.Migrations
{
    public partial class AddedFieldsToGradModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrojSkola",
                table: "Grads",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Drzava",
                table: "Grads",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ProracunGrada",
                table: "Grads",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojSkola",
                table: "Grads");

            migrationBuilder.DropColumn(
                name: "Drzava",
                table: "Grads");

            migrationBuilder.DropColumn(
                name: "ProracunGrada",
                table: "Grads");
        }
    }
}
