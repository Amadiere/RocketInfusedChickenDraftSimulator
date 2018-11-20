using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RocketInfusedChicken.Database.Migrations
{
    public partial class ManyT2Many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sets_SetId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Printings",
                table: "Printings");

            migrationBuilder.DropIndex(
                name: "IX_Printings_CardId",
                table: "Printings");

            migrationBuilder.DropIndex(
                name: "IX_Cards_SetId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Printings");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "Cards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Printings",
                table: "Printings",
                columns: new[] { "CardId", "SetId" });

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2018, 11, 20, 22, 24, 30, 586, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2017, 4, 20, 22, 24, 30, 587, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Printings",
                table: "Printings");

            migrationBuilder.DeleteData(
                table: "Printings",
                keyColumns: new[] { "CardId", "SetId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "Printings",
                keyColumns: new[] { "CardId", "SetId" },
                keyValues: new object[] { 1, 51 });

            migrationBuilder.DeleteData(
                table: "Printings",
                keyColumns: new[] { "CardId", "SetId" },
                keyValues: new object[] { 2, 33 });

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Printings",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Printings",
                table: "Printings",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Printings",
                columns: new[] { "Id", "CardId", "SetId" },
                values: new object[,]
                {
                    { 1, 1, 33 },
                    { 2, 2, 33 },
                    { 3, 1, 51 }
                });

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2018, 11, 20, 21, 57, 59, 195, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 51,
                column: "ReleaseDate",
                value: new DateTime(2017, 4, 20, 21, 57, 59, 197, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Printings_CardId",
                table: "Printings",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_SetId",
                table: "Cards",
                column: "SetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sets_SetId",
                table: "Cards",
                column: "SetId",
                principalTable: "Sets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
