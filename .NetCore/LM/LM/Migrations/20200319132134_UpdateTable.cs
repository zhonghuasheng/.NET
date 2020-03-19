using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LM.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShotDescription",
                table: "Noodles",
                newName: "ShortDescription");

            migrationBuilder.AlterColumn<bool>(
                name: "IsInStock",
                table: "Noodles",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Noodles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Noodles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "FeedBacks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Noodles");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Noodles");

            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "FeedBacks");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Noodles",
                newName: "ShotDescription");

            migrationBuilder.AlterColumn<bool>(
                name: "IsInStock",
                table: "Noodles",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
