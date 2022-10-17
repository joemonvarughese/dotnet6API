using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace core6WebAPI.Migrations
{
    public partial class initialM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Waks_Regions_RegionId",
                table: "Waks");

            migrationBuilder.DropForeignKey(
                name: "FK_Waks_WalkDifficulty_WalkDifficultyId",
                table: "Waks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Waks",
                table: "Waks");

            migrationBuilder.RenameTable(
                name: "Waks",
                newName: "Walks");

            migrationBuilder.RenameIndex(
                name: "IX_Waks_WalkDifficultyId",
                table: "Walks",
                newName: "IX_Walks_WalkDifficultyId");

            migrationBuilder.RenameIndex(
                name: "IX_Waks_RegionId",
                table: "Walks",
                newName: "IX_Walks_RegionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Walks",
                table: "Walks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Walks_Regions_RegionId",
                table: "Walks",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Walks_WalkDifficulty_WalkDifficultyId",
                table: "Walks",
                column: "WalkDifficultyId",
                principalTable: "WalkDifficulty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Walks_Regions_RegionId",
                table: "Walks");

            migrationBuilder.DropForeignKey(
                name: "FK_Walks_WalkDifficulty_WalkDifficultyId",
                table: "Walks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Walks",
                table: "Walks");

            migrationBuilder.RenameTable(
                name: "Walks",
                newName: "Waks");

            migrationBuilder.RenameIndex(
                name: "IX_Walks_WalkDifficultyId",
                table: "Waks",
                newName: "IX_Waks_WalkDifficultyId");

            migrationBuilder.RenameIndex(
                name: "IX_Walks_RegionId",
                table: "Waks",
                newName: "IX_Waks_RegionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Waks",
                table: "Waks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Waks_Regions_RegionId",
                table: "Waks",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Waks_WalkDifficulty_WalkDifficultyId",
                table: "Waks",
                column: "WalkDifficultyId",
                principalTable: "WalkDifficulty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
