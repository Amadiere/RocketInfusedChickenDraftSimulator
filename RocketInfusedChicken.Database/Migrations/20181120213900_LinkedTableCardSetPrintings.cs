using Microsoft.EntityFrameworkCore.Migrations;

namespace RocketInfusedChicken.Database.Migrations
{
    public partial class LinkedTableCardSetPrintings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Printings_CardId",
                table: "Printings",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Printings_SetId",
                table: "Printings",
                column: "SetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Printings_Cards_CardId",
                table: "Printings",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printings_Sets_SetId",
                table: "Printings",
                column: "SetId",
                principalTable: "Sets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Printings_Cards_CardId",
                table: "Printings");

            migrationBuilder.DropForeignKey(
                name: "FK_Printings_Sets_SetId",
                table: "Printings");

            migrationBuilder.DropIndex(
                name: "IX_Printings_CardId",
                table: "Printings");

            migrationBuilder.DropIndex(
                name: "IX_Printings_SetId",
                table: "Printings");
        }
    }
}
