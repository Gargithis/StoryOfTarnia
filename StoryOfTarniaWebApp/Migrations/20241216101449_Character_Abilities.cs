using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoryOfTarniaWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Character_Abilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    AbilityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbilityDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbilityScore = table.Column<int>(type: "int", nullable: false),
                    AbilityModifier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.AbilityID);
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "AbilityID", "AbilityDesc", "AbilityModifier", "AbilityName", "AbilityScore" },
                values: new object[,]
                {
                    { 1, "Strength measures a character's physical power, including their ability to lift, push, pull, and perform feats of raw might. It's crucial for characters who rely on melee combat and physical prowess.", -1, "Strength", 8 },
                    { 2, "Dexterity represents agility, reflexes, and balance. It's critical for characters who rely on speed and precision, such as rogues and rangers.", -1, "Dexterity", 8 },
                    { 3, "Constitution measures endurance and health. It determines how well a character resists physical stress, illness, and how much punishment they can take.", -1, "Constitution", 8 },
                    { 4, "Intelligence reflects mental acuity, analytical ability, and memory. It’s vital for spellcasters like wizards and for understanding complex problems.", -1, "Intelligence", 8 },
                    { 5, "Wisdom reflects perception, intuition, and awareness of the world. It's crucial for clerics, druids, and other characters who rely on insight.", -1, "Wisdom", 8 },
                    { 6, "Charisma measures force of personality, persuasiveness, and leadership. It's essential for characters like bards, sorcerers, and warlocks.", -1, "Charisma", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abilities");
        }
    }
}
