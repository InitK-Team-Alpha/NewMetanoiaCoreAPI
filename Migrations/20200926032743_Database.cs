using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test_project2.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminUserDTOs",
                table: "AdminUserDTOs");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AdminUserDTOs");

            migrationBuilder.RenameTable(
                name: "AdminUserDTOs",
                newName: "admins");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "admins",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "admins",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_admins",
                table: "admins",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "appuser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PsychologyCausesID = table.Column<int>(type: "INTEGER", nullable: false),
                    PsychologyEffectsID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Password = table.Column<string>(type: "varchar(30)", nullable: false),
                    Age = table.Column<int>(type: "smallint", nullable: false),
                    Gender = table.Column<int>(type: "varchar(12)", nullable: false),
                    JobRole = table.Column<string>(type: "varchar(200)", nullable: false),
                    RelationshipStatus = table.Column<int>(type: "varchar(14)", nullable: false),
                    varchar200 = table.Column<string>(name: "varchar(200)", type: "TEXT", nullable: false),
                    varchar30 = table.Column<string>(name: "varchar(30)", type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appuser", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appuser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admins",
                table: "admins");

            migrationBuilder.RenameTable(
                name: "admins",
                newName: "AdminUserDTOs");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AdminUserDTOs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AdminUserDTOs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AdminUserDTOs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminUserDTOs",
                table: "AdminUserDTOs",
                column: "ID");
        }
    }
}
