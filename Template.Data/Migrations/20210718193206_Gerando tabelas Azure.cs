using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Data.Migrations
{
    public partial class GerandotabelasAzure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 18, 16, 32, 5, 443, DateTimeKind.Local).AddTicks(6577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 18, 13, 59, 7, 8, DateTimeKind.Local).AddTicks(1303));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 18, 13, 59, 7, 8, DateTimeKind.Local).AddTicks(1303),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 18, 16, 32, 5, 443, DateTimeKind.Local).AddTicks(6577));
        }
    }
}
