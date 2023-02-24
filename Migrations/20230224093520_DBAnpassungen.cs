using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG2_Arbeitsblaetter.Migrations
{
    /// <inheritdoc />
    public partial class DBAnpassungen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunde");

            migrationBuilder.DropTable(
                name: "ManchesterUnited");

            migrationBuilder.DropTable(
                name: "Lieferkosten");

            migrationBuilder.CreateTable(
                name: "Team",
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
                    table.PrimaryKey("PK_Team", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Team_Player_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Team_PlayerID",
                table: "Team",
                column: "PlayerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.CreateTable(
                name: "Lieferkosten",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preis = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieferkosten", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ManchesterUnited",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Kunde",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LieferkostenID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ortschaft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunde", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kunde_Lieferkosten_LieferkostenID",
                        column: x => x.LieferkostenID,
                        principalTable: "Lieferkosten",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kunde_LieferkostenID",
                table: "Kunde",
                column: "LieferkostenID");

            migrationBuilder.CreateIndex(
                name: "IX_ManchesterUnited_PlayerID",
                table: "ManchesterUnited",
                column: "PlayerID");
        }
    }
}
