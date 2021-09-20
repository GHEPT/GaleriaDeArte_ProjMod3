using Microsoft.EntityFrameworkCore.Migrations;

namespace GaleriaDeArte.Migrations
{
    public partial class rmvfkusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Lance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Lance",
                type: "int",
                nullable: true);
        }
    }
}
