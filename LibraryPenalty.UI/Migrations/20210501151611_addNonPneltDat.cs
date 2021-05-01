using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryPenalty.UI.Migrations
{
    public partial class addNonPneltDat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NonPanelty",
                table: "Penalties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NonPanelty",
                table: "Penalties");
        }
    }
}
