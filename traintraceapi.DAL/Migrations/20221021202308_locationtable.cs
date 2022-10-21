using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace traintraceapi.DAL.Migrations
{
    public partial class locationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CountryId",
                table: "Locations",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Countries_CountryId",
                table: "Locations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Countries_CountryId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CountryId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Locations");
        }
    }
}
