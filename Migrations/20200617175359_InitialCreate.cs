using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileId);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    NumBeds = table.Column<int>(nullable: false),
                    NumBaths = table.Column<decimal>(nullable: false),
                    IsStudio = table.Column<bool>(nullable: false),
                    Sqft = table.Column<int>(nullable: false),
                    HomeType = table.Column<string>(nullable: true),
                    NumParkingSpots = table.Column<int>(nullable: false),
                    NumGarageSpots = table.Column<int>(nullable: false),
                    AttachedGarage = table.Column<bool>(nullable: false),
                    LotSize = table.Column<decimal>(nullable: false),
                    YearBuilt = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                });

            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    ListingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingType = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ListDate = table.Column<DateTime>(nullable: false),
                    ClosedDate = table.Column<DateTime>(nullable: true),
                    PropertyId = table.Column<int>(nullable: false),
                    ProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.ListingId);
                    table.ForeignKey(
                        name: "FK_Listings_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Listings_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoritedListing",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false),
                    ListingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritedListing", x => new { x.ProfileId, x.ListingId });
                    table.ForeignKey(
                        name: "FK_FavoritedListing_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "ListingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoritedListing_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    ListingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "ListingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoritedListing_ListingId",
                table: "FavoritedListing",
                column: "ListingId");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_ProfileId",
                table: "Listings",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_PropertyId",
                table: "Listings",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ListingId",
                table: "Photos",
                column: "ListingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoritedListing");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Listings");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
