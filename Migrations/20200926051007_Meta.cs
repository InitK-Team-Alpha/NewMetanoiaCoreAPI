using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test_project2.Migrations
{
    public partial class Meta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "appuser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "appuser",
                type: "date",
                nullable: false,
                defaultValueSql: "DateTime.Now()");
        }
    }
}
