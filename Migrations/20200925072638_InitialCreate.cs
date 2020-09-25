using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test_project2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    Role = table.Column<int>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserPsychologyCauses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RelationshipProblem = table.Column<bool>(type: "INTEGER", nullable: false),
                    FamilyConflict = table.Column<bool>(type: "INTEGER", nullable: false),
                    LossingSomeone = table.Column<bool>(type: "INTEGER", nullable: false),
                    Rape = table.Column<bool>(type: "INTEGER", nullable: false),
                    SexualAbuse = table.Column<bool>(type: "INTEGER", nullable: false),
                    WorkProblem = table.Column<bool>(type: "INTEGER", nullable: false),
                    ClingtoSomething = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPsychologyCauses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserPsychologyEffects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SleepProblem = table.Column<bool>(type: "INTEGER", nullable: false),
                    LossofAppetite = table.Column<bool>(type: "INTEGER", nullable: false),
                    WeightLossORWeightGain = table.Column<bool>(type: "INTEGER", nullable: false),
                    FocusProblem = table.Column<bool>(type: "INTEGER", nullable: false),
                    AngerProblem = table.Column<bool>(type: "INTEGER", nullable: false),
                    ConstantWorry = table.Column<bool>(type: "INTEGER", nullable: false),
                    LonelinessORIsolation = table.Column<bool>(type: "INTEGER", nullable: false),
                    FeelingOverWhelmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Unhappiness = table.Column<bool>(type: "INTEGER", nullable: false),
                    SuicidalThoughts = table.Column<bool>(type: "INTEGER", nullable: false),
                    NoJoy = table.Column<bool>(type: "INTEGER", nullable: false),
                    FeelingSadORDown = table.Column<bool>(type: "INTEGER", nullable: false),
                    OveruseOfAlcholAndDrugs = table.Column<bool>(type: "INTEGER", nullable: false),
                    WithdrawFromFriendsORActivities = table.Column<bool>(type: "INTEGER", nullable: false),
                    SexDriveChange = table.Column<bool>(type: "INTEGER", nullable: false),
                    MoodSwing = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPsychologyEffects", x => x.ID);
                });

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
                    varchar30 = table.Column<string>(name: "varchar(30)", type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appuser", x => x.ID);
                    table.ForeignKey(
                        name: "FK_appuser_UserPsychologyCauses_PsychologyCausesID",
                        column: x => x.PsychologyCausesID,
                        principalTable: "UserPsychologyCauses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appuser_UserPsychologyEffects_PsychologyEffectsID",
                        column: x => x.PsychologyEffectsID,
                        principalTable: "UserPsychologyEffects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_appuser_PsychologyCausesID",
                table: "appuser",
                column: "PsychologyCausesID");

            migrationBuilder.CreateIndex(
                name: "IX_appuser_PsychologyEffectsID",
                table: "appuser",
                column: "PsychologyEffectsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "appuser");

            migrationBuilder.DropTable(
                name: "UserPsychologyCauses");

            migrationBuilder.DropTable(
                name: "UserPsychologyEffects");
        }
    }
}
