using Microsoft.EntityFrameworkCore.Migrations;

namespace LM.Migrations
{
    public partial class UpdateColumnProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsInStock",
                table: "Noodles",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsInStock",
                table: "Noodles",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
