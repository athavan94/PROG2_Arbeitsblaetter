using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PROG2_Arbeitsblaetter.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Das beste Team der Welt!", "Manchester United" },
                    { 2, "Gibt zu viel Geld aus :D", "Chelsea" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "ID", "Name", "Nationalität", "Position", "TeamID", "Vorname" },
                values: new object[,]
                {
                    { 1, "Rashford", "England", "Linksaussen", 1, "Marcus" },
                    { 2, "Pedri", "Spanien", "Zentrales Mittelfeld", 2, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
