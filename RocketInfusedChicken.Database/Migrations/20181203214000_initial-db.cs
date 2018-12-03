using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RocketInfusedChicken.Database.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MultiverseId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    ManaCost = table.Column<string>(maxLength: 50, nullable: true),
                    Layout = table.Column<string>(maxLength: 25, nullable: true),
                    ConvertedManaCost = table.Column<int>(nullable: false),
                    CardTypeText = table.Column<string>(maxLength: 255, nullable: true),
                    Rarity = table.Column<string>(maxLength: 15, nullable: true),
                    Text = table.Column<string>(maxLength: 1000, nullable: true),
                    Power = table.Column<int>(nullable: false),
                    Toughness = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShortCode = table.Column<string>(maxLength: 1, nullable: true),
                    Name = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DraftPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DraftId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraftPlayers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drafts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drafts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DraftId = table.Column<int>(nullable: false),
                    SetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Block = table.Column<string>(maxLength: 50, nullable: true),
                    Code = table.Column<string>(maxLength: 5, nullable: true),
                    SetType = table.Column<string>(maxLength: 15, nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpellSubTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSubTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpellSuperTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSuperTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpellTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardColors",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardColors", x => new { x.CardId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_CardColors_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Printings",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false),
                    SetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printings", x => new { x.CardId, x.SetId });
                    table.ForeignKey(
                        name: "FK_Printings_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Printings_Sets_SetId",
                        column: x => x.SetId,
                        principalTable: "Sets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardSpellSubTypes",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false),
                    SpellSubTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSpellSubTypes", x => new { x.CardId, x.SpellSubTypeId });
                    table.ForeignKey(
                        name: "FK_CardSpellSubTypes_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardSpellSubTypes_SpellSubTypes_SpellSubTypeId",
                        column: x => x.SpellSubTypeId,
                        principalTable: "SpellSubTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardSpellSuperTypes",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false),
                    SpellSuperTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSpellSuperTypes", x => new { x.CardId, x.SpellSuperTypeId });
                    table.ForeignKey(
                        name: "FK_CardSpellSuperTypes_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardSpellSuperTypes_SpellSuperTypes_SpellSuperTypeId",
                        column: x => x.SpellSuperTypeId,
                        principalTable: "SpellSuperTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardSpellTypes",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false),
                    SpellTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSpellTypes", x => new { x.CardId, x.SpellTypeId });
                    table.ForeignKey(
                        name: "FK_CardSpellTypes_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardSpellTypes_SpellTypes_SpellTypeId",
                        column: x => x.SpellTypeId,
                        principalTable: "SpellTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardTypeText", "ConvertedManaCost", "ImageUrl", "Layout", "ManaCost", "MultiverseId", "Name", "Power", "Rarity", "Text", "Toughness" },
                values: new object[,]
                {
                    { 1, null, 0, null, null, null, 1000, "Alex Rocks", 0, null, null, 0 },
                    { 2, null, 0, null, null, null, 666, "Sammer Smells", 0, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name", "ShortCode" },
                values: new object[,]
                {
                    { 1, "White", "W" },
                    { 2, "Black", "B" },
                    { 3, "Blue", "U" },
                    { 4, "Green", "G" },
                    { 5, "Red", "R" }
                });

            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "Id", "Block", "Code", "Name", "ReleaseDate", "SetType" },
                values: new object[,]
                {
                    { 33, null, "GOS", "Guilds of Shropshire", new DateTime(2018, 12, 3, 21, 39, 59, 546, DateTimeKind.Local), null },
                    { 51, null, "INS", "Innastruggle", new DateTime(2017, 5, 3, 21, 39, 59, 548, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "SpellSubTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Wizard" },
                    { 3, "Zombie" },
                    { 5, "Human" },
                    { 1, "Angel" },
                    { 2, "Vampire" }
                });

            migrationBuilder.InsertData(
                table: "SpellSuperTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Basic" },
                    { 2, "Legendary" },
                    { 3, "Ongoing" },
                    { 4, "Snow" },
                    { 5, "World" }
                });

            migrationBuilder.InsertData(
                table: "SpellTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Scheme" },
                    { 1, "Artifact" },
                    { 2, "Creature" },
                    { 3, "Enchantment" },
                    { 4, "Instant" },
                    { 5, "Land" },
                    { 6, "Planeswalker" },
                    { 8, "Sorcery" }
                });

            migrationBuilder.InsertData(
                table: "CardSpellSubTypes",
                columns: new[] { "CardId", "SpellSubTypeId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 4 },
                    { 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "CardSpellSuperTypes",
                columns: new[] { "CardId", "SpellSuperTypeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CardSpellTypes",
                columns: new[] { "CardId", "SpellTypeId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Printings",
                columns: new[] { "CardId", "SetId" },
                values: new object[,]
                {
                    { 1, 33 },
                    { 2, 33 },
                    { 1, 51 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardColors_ColorId",
                table: "CardColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSpellSubTypes_SpellSubTypeId",
                table: "CardSpellSubTypes",
                column: "SpellSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSpellSuperTypes_SpellSuperTypeId",
                table: "CardSpellSuperTypes",
                column: "SpellSuperTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSpellTypes_SpellTypeId",
                table: "CardSpellTypes",
                column: "SpellTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Printings_SetId",
                table: "Printings",
                column: "SetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardColors");

            migrationBuilder.DropTable(
                name: "CardSpellSubTypes");

            migrationBuilder.DropTable(
                name: "CardSpellSuperTypes");

            migrationBuilder.DropTable(
                name: "CardSpellTypes");

            migrationBuilder.DropTable(
                name: "DraftPlayers");

            migrationBuilder.DropTable(
                name: "Drafts");

            migrationBuilder.DropTable(
                name: "Packs");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Printings");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "SpellSubTypes");

            migrationBuilder.DropTable(
                name: "SpellSuperTypes");

            migrationBuilder.DropTable(
                name: "SpellTypes");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Sets");
        }
    }
}
