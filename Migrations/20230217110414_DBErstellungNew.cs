using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG2_Arbeitsblaetter.Migrations
{
    /// <inheritdoc />
    public partial class DBErstellungNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationalität = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ManchesterUnited",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManchesterUnited", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ManchesterUnited_Player_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManchesterUnited_PlayerID",
                table: "ManchesterUnited",
                column: "PlayerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManchesterUnited");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
