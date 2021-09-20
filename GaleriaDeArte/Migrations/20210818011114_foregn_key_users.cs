using Microsoft.EntityFrameworkCore.Migrations;

namespace GaleriaDeArte.Migrations
{
    public partial class foregn_key_users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Lance",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Lance");
        }
    }
}
