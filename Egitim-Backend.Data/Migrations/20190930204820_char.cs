using Microsoft.EntityFrameworkCore.Migrations;

namespace Egitim_Backend.Data.Migrations
{
    public partial class @char : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Users",
                nullable: false,
                oldClrType: typeof(byte));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Gender",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
