using Microsoft.EntityFrameworkCore.Migrations;

namespace test_project2.Migrations
{
    public partial class ModifiedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "admins",
                type: "varchar(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "causes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RelationshipProblem = table.Column<bool>(type: "varchar(10)", nullable: false),
                    FamilyConflict = table.Column<bool>(type: "varchar(10)", nullable: false),
                    LossingSomeone = table.Column<bool>(type: "varchar(10)", nullable: false),
                    Rape = table.Column<bool>(type: "varchar(10)", nullable: false),
                    SexualAbuse = table.Column<bool>(type: "varchar(10)", nullable: false),
                    WorkProblem = table.Column<bool>(type: "varchar(10)", nullable: false),
                    ClingtoSomething = table.Column<bool>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_causes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "efffects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SleepProblem = table.Column<bool>(type: "varchar(10)", nullable: false),
                    LossofAppetite = table.Column<bool>(type: "varchar(10)", nullable: false),
                    WeightLossORWeightGain = table.Column<bool>(type: "varchar(10)", nullable: false),
                    FocusProblem = table.Column<bool>(type: "varchar(10)", nullable: false),
                    AngerProblem = table.Column<bool>(type: "varchar(10)", nullable: false),
                    ConstantWorry = table.Column<bool>(type: "varchar(10)", nullable: false),
                    LonelinessORIsolation = table.Column<bool>(type: "varchar(10)", nullable: false),
                    FeelingOverWhelmed = table.Column<bool>(type: "varchar(10)", nullable: false),
                    Unhappiness = table.Column<bool>(type: "varchar(10)", nullable: false),
                    SuicidalThoughts = table.Column<bool>(type: "varchar(10)", nullable: false),
                    NoJoy = table.Column<bool>(type: "varchar(10)", nullable: false),
                    FeelingSadORDown = table.Column<bool>(type: "varchar(10)", nullable: false),
                    OveruseOfAlcholAndDrugs = table.Column<bool>(type: "varchar(10)", nullable: false),
                    WithdrawFromFriendsORActivities = table.Column<bool>(type: "varchar(10)", nullable: false),
                    SexDriveChange = table.Column<bool>(type: "varchar(10)", nullable: false),
                    MoodSwing = table.Column<bool>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_efffects", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_appuser_PsychologyCausesID",
                table: "appuser",
                column: "PsychologyCausesID");

            migrationBuilder.CreateIndex(
                name: "IX_appuser_PsychologyEffectsID",
                table: "appuser",
                column: "PsychologyEffectsID");

            migrationBuilder.AddForeignKey(
                name: "FK_appuser_causes_PsychologyCausesID",
                table: "appuser",
                column: "PsychologyCausesID",
                principalTable: "causes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appuser_efffects_PsychologyEffectsID",
                table: "appuser",
                column: "PsychologyEffectsID",
                principalTable: "efffects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appuser_causes_PsychologyCausesID",
                table: "appuser");

            migrationBuilder.DropForeignKey(
                name: "FK_appuser_efffects_PsychologyEffectsID",
                table: "appuser");

            migrationBuilder.DropTable(
                name: "causes");

            migrationBuilder.DropTable(
                name: "efffects");

            migrationBuilder.DropIndex(
                name: "IX_appuser_PsychologyCausesID",
                table: "appuser");

            migrationBuilder.DropIndex(
                name: "IX_appuser_PsychologyEffectsID",
                table: "appuser");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "admins");
        }
    }
}
