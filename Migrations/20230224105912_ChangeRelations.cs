using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG2_Arbeitsblaetter.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_Player_PlayerID",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_PlayerID",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "PlayerID",
                table: "Team");

            migrationBuilder.AddColumn<int>(
                name: "TeamID",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamID",
                table: "Player",
                column: "TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_TeamID",
                table: "Player",
                column: "TeamID",
                principalTable: "Team",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_TeamID",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_TeamID",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "Player");

            migrationBuilder.AddColumn<int>(
                name: "PlayerID",
                table: "Team",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Team_PlayerID",
                table: "Team",
                column: "PlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Player_PlayerID",
                table: "Team",
                column: "PlayerID",
                principalTable: "Player",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
