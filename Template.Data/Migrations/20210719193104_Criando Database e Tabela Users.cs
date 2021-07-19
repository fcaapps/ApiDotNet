using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Data.Migrations
{
    public partial class CriandoDatabaseeTabelaUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 7, 19, 16, 31, 3, 691, DateTimeKind.Local).AddTicks(7270)),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Email", "Name" },
                values: new object[] { new Guid("c7dce21b-d207-4869-bf5f-08eb138bb919"), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "userdefault@template.com", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
