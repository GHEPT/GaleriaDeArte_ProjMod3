using Microsoft.EntityFrameworkCore.Migrations;

namespace GaleriaDeArte.Migrations
{
    public partial class fkidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Lance",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lance_UserId",
                table: "Lance",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lance_AspNetUsers_UserId",
                table: "Lance",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lance_AspNetUsers_UserId",
                table: "Lance");

            migrationBuilder.DropIndex(
                name: "IX_Lance_UserId",
                table: "Lance");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Lance");
        }
    }
}
