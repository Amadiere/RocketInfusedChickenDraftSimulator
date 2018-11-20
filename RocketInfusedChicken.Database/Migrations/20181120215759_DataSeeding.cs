using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RocketInfusedChicken.Database.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "MultiverseId", "Name", "SetId" },
                values: new object[,]
                {
                    { 1, 1000, "Alex Rocks", null },
                    { 2, 666, "Sammer Smells", null }
                });

            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "Id", "Code", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 33, "GOS", "Guilds of Shropshire", new DateTime(2018, 11, 20, 21, 57, 59, 195, DateTimeKind.Local) },
                    { 51, "INS", "Innastruggle", new DateTime(2017, 4, 20, 21, 57, 59, 197, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Printings",
                columns: new[] { "Id", "CardId", "SetId" },
                values: new object[] { 1, 1, 33 });

            migrationBuilder.InsertData(
                table: "Printings",
                columns: new[] { "Id", "CardId", "SetId" },
                values: new object[] { 2, 2, 33 });

            migrationBuilder.InsertData(
                table: "Printings",
                columns: new[] { "Id", "CardId", "SetId" },
                values: new object[] { 3, 1, 51 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Printings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Printings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Printings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 51);
        }
    }
}
