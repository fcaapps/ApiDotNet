using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Data.Migrations
{
    public partial class GerandoTabelaTemplateAzure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 18, 16, 46, 34, 111, DateTimeKind.Local).AddTicks(2485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 18, 16, 44, 37, 435, DateTimeKind.Local).AddTicks(1567));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 18, 16, 44, 37, 435, DateTimeKind.Local).AddTicks(1567),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 18, 16, 46, 34, 111, DateTimeKind.Local).AddTicks(2485));
        }
    }
}
