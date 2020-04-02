using Microsoft.EntityFrameworkCore.Migrations;

namespace CharacterCreationAPI.Migrations
{
    public partial class updateCharacterClassModelRemoveAbilityScores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterClasses_AbilityScores_AbilityScoresId",
                table: "CharacterClasses");

            migrationBuilder.DropIndex(
                name: "IX_CharacterClasses_AbilityScoresId",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "AbilityScoresId",
                table: "CharacterClasses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AbilityScoresId",
                table: "CharacterClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_AbilityScoresId",
                table: "CharacterClasses",
                column: "AbilityScoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterClasses_AbilityScores_AbilityScoresId",
                table: "CharacterClasses",
                column: "AbilityScoresId",
                principalTable: "AbilityScores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
