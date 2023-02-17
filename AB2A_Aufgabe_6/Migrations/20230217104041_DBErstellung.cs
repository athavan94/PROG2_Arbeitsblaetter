using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG2_Arbeitsblaetter.Migrations
{
    /// <inheritdoc />
    public partial class DBErstellung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Kunde",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ortschaft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LieferkostenID = table.Column<int>(type: "int", nullable: false)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunde");

            migrationBuilder.DropTable(
                name: "Lieferkosten");
        }
    }
}
