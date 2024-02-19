using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MycoMatrix.Migrations
{
    public partial class AddEditor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Editor",
                table: "Mushrooms",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 1,
                column: "Editor",
                value: "Kim Robinson");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 2,
                column: "Editor",
                value: "Mickey Mouse");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 3,
                column: "Editor",
                value: "Kim Robinson");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 4,
                column: "Editor",
                value: "Henry Oberholtzer");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 5,
                column: "Editor",
                value: "Kim Robinson");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 6,
                column: "Editor",
                value: "Paul Stamets");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 7,
                column: "Editor",
                value: "Henry Oberholtzer");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 8,
                column: "Editor",
                value: "Paul Stamets");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 9,
                column: "Editor",
                value: "Kim Robinson");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 10,
                column: "Editor",
                value: "Henry Oberholtzer");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 11,
                column: "Editor",
                value: "Paul Stamets");

            migrationBuilder.UpdateData(
                table: "Mushrooms",
                keyColumn: "MushroomId",
                keyValue: 12,
                column: "Editor",
                value: "Pedro Pascal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Editor",
                table: "Mushrooms");
        }
    }
}
