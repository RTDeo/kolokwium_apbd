using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kolokwium_apbd.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Available_Program",
                columns: table => new
                {
                    AvailableProgramId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WashingMachineId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProgramId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Available_Program", x => x.AvailableProgramId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    ProgramId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DurationMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    TemperatureCelsius = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ProgramId);
                });

            migrationBuilder.CreateTable(
                name: "WashingMachines",
                columns: table => new
                {
                    WashingMachineId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaxWeight = table.Column<int>(type: "INTEGER", nullable: false),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashingMachines", x => x.WashingMachineId);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_History",
                columns: table => new
                {
                    AvailableProgramId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_History", x => new { x.AvailableProgramId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_Purchase_History_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Available_Program",
                columns: new[] { "AvailableProgramId", "Price", "ProgramId", "WashingMachineId" },
                values: new object[] { 1, 200m, 1, 1 });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, "Bob", "Smith", "111222333" });

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "ProgramId", "DurationMinutes", "Name", "TemperatureCelsius" },
                values: new object[] { 1, 10, "Something", 30 });

            migrationBuilder.InsertData(
                table: "WashingMachines",
                columns: new[] { "WashingMachineId", "MaxWeight", "SerialNumber" },
                values: new object[] { 1, 500, "255335836" });

            migrationBuilder.InsertData(
                table: "Purchase_History",
                columns: new[] { "AvailableProgramId", "CustomerId", "PurchaseDate", "Rating" },
                values: new object[] { 1, 1, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_History_CustomerId",
                table: "Purchase_History",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Available_Program");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "Purchase_History");

            migrationBuilder.DropTable(
                name: "WashingMachines");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
