using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    /// <inheritdoc />
    public partial class CapitalWords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "url",
                table: "Stock",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "targetMedian",
                table: "Stock",
                newName: "TargetMedian");

            migrationBuilder.RenameColumn(
                name: "targetLow",
                table: "Stock",
                newName: "TargetLow");

            migrationBuilder.RenameColumn(
                name: "targetHigh",
                table: "Stock",
                newName: "TargetHigh");

            migrationBuilder.RenameColumn(
                name: "targetConsensus",
                table: "Stock",
                newName: "TargetConsensus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Stock",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "TargetMedian",
                table: "Stock",
                newName: "targetMedian");

            migrationBuilder.RenameColumn(
                name: "TargetLow",
                table: "Stock",
                newName: "targetLow");

            migrationBuilder.RenameColumn(
                name: "TargetHigh",
                table: "Stock",
                newName: "targetHigh");

            migrationBuilder.RenameColumn(
                name: "TargetConsensus",
                table: "Stock",
                newName: "targetConsensus");
        }
    }
}
