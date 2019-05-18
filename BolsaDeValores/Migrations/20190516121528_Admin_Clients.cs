using Microsoft.EntityFrameworkCore.Migrations;

namespace BolsaDeValores.Migrations
{
    public partial class Admin_Clients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Admin",
                table: "Clients",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admin",
                table: "Clients");
        }
    }
}
