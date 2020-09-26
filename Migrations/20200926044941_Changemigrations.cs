using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test_project2.Migrations
{
    public partial class Changemigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PsychologyCausess",
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
                    table.PrimaryKey("PK_PsychologyCausess", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PsychologyEffectss",
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
                    table.PrimaryKey("PK_PsychologyEffectss", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppUsersDTos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PsychologyCausesID = table.Column<int>(type: "INTEGER", nullable: false),
                    PsychologyEffectsID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    JobRole = table.Column<string>(type: "TEXT", nullable: true),
                    RelationshipStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    Hobbies = table.Column<string>(type: "TEXT", nullable: true),
                    Religion = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsersDTos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AppUsersDTos_PsychologyCausess_PsychologyCausesID",
                        column: x => x.PsychologyCausesID,
                        principalTable: "PsychologyCausess",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUsersDTos_PsychologyEffectss_PsychologyEffectsID",
                        column: x => x.PsychologyEffectsID,
                        principalTable: "PsychologyEffectss",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsersDTos_PsychologyCausesID",
                table: "AppUsersDTos",
                column: "PsychologyCausesID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsersDTos_PsychologyEffectsID",
                table: "AppUsersDTos",
                column: "PsychologyEffectsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsersDTos");

            migrationBuilder.DropTable(
                name: "PsychologyCausess");

            migrationBuilder.DropTable(
                name: "PsychologyEffectss");
        }
    }
}
