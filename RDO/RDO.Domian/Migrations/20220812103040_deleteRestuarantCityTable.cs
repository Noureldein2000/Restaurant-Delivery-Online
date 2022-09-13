using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RDO.Domian.Migrations
{
    public partial class deleteRestuarantCityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantCities");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CityId",
                table: "Restaurants",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Cities_CityId",
                table: "Restaurants",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Cities_CityId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_CityId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Restaurants");

            migrationBuilder.CreateTable(
                name: "RestaurantCities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantCities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RestaurantCities_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RestaurantCities_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCities_CityID",
                table: "RestaurantCities",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCities_RestaurantID",
                table: "RestaurantCities",
                column: "RestaurantID");
        }
    }
}
