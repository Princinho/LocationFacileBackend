﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocationFacileBackend.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    GPSCoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedroomsCount = table.Column<int>(type: "int", nullable: false),
                    BathroomsCount = table.Column<int>(type: "int", nullable: false),
                    ParkingSpotsCount = table.Column<int>(type: "int", nullable: false),
                    Surface = table.Column<double>(type: "float", nullable: false),
                    PetsAllowed = table.Column<bool>(type: "bit", nullable: false),
                    HouseholdsCount = table.Column<int>(type: "int", nullable: false),
                    FloorCount = table.Column<int>(type: "int", nullable: false),
                    FloorNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}