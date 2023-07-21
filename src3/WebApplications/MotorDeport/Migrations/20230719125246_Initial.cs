using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MotorDeport.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsWork = table.Column<bool>(type: "bit", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsWork = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromCityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToCityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trip_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trip_City_FromCityId",
                        column: x => x.FromCityId,
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trip_City_ToCityId",
                        column: x => x.ToCityId,
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trip_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1c75d9fb-ba88-4dc7-acab-797aaede2840"), "Ростов-на-Дону" },
                    { new Guid("b3dcad0e-7eda-4aa4-ae97-d8ecb9cec4e2"), "Армавир" },
                    { new Guid("be0e8522-47a4-49df-aa50-3e25ccf457a6"), "Москва" },
                    { new Guid("faee47bb-316f-4622-83a6-2aefcd0b0e57"), "Краснодар" },
                    { new Guid("ff75896f-fdbc-4ab4-ad4a-3790ffdb7c37"), "Темрюк" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trip_CarId",
                table: "Trip",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_DriverId",
                table: "Trip",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_FromCityId",
                table: "Trip",
                column: "FromCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_ToCityId",
                table: "Trip",
                column: "ToCityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trip");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Driver");
        }
    }
}
