using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateWebApp.Migrations
{
    public partial class InitialPropertyCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NumBeds = table.Column<int>(nullable: false),
                    NumBaths = table.Column<decimal>(nullable: false),
                    IsStudio = table.Column<bool>(nullable: false),
                    Sqft = table.Column<int>(nullable: false),
                    HomeType = table.Column<string>(nullable: true),
                    NumParkingSpots = table.Column<int>(nullable: false),
                    NumGarageSpots = table.Column<int>(nullable: false),
                    AttachedGarage = table.Column<bool>(nullable: false),
                    LotSize = table.Column<decimal>(nullable: false),
                    YearBuilt = table.Column<DateTime>(nullable: false),
                    LatestRenovationDate = table.Column<DateTime>(nullable: true),
                    LatestRenovationDescription = table.Column<string>(nullable: true),
                    Heating = table.Column<string>(nullable: true),
                    Cooling = table.Column<string>(nullable: true),
                    Flooring = table.Column<string>(nullable: true),
                    NumStories = table.Column<int>(nullable: false),
                    HasBasement = table.Column<bool>(nullable: false),
                    Gas = table.Column<string>(nullable: true),
                    Electric = table.Column<string>(nullable: true),
                    Sewer = table.Column<string>(nullable: true),
                    Internet = table.Column<string>(nullable: true),
                    TV = table.Column<string>(nullable: true),
                    OtherDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
