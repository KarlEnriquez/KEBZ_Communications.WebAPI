using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KEBZ_Communications.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DbCreateWithConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DeviceLimit = table.Column<int>(type: "int", nullable: false),
                    DataLimit = table.Column<int>(type: "int", nullable: false),
                    MinuteLimit = table.Column<int>(type: "int", nullable: false),
                    TextLimit = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMEI = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceId);
                    table.ForeignKey(
                        name: "FK_Devices_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPlans",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlans", x => new { x.UserId, x.PlanId });
                    table.ForeignKey(
                        name: "FK_UserPlans_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPlans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "PlanId", "CreatedAt", "DataLimit", "DeviceLimit", "MinuteLimit", "PlanDescription", "PlanName", "Price", "TextLimit" },
                values: new object[,]
                {
                    { new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1864), -1, 5, -1, "Stay connected without limits. Enjoy unlimited data, minutes, and texts for up to 5 devices", "Unlimited Family Plan", 0m, -1 },
                    { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1862), -1, 2, -1, "Stay connected without limits. Enjoy unlimited data, minutes, and texts for up to 2 devices", "Unlimited Personal Plan", 0m, -1 },
                    { new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1871), 10, 2, -1, "Stay connected with friends, family, and colleagues without counting minutes. Connect up to 2 devices", "Oops! All minutes!", 0m, 1000 },
                    { new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1869), -1, 2, 1000, "Stay connected without worrying about data limits. Enjoy unlimited data for up to 2 devices", "Oops! All data!", 0m, 1000 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Username", "status" },
                values: new object[,]
                {
                    { new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1739), "email1@email.com", "Bryan", "Zbojna", "password1", "username1", true },
                    { new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1754), "email3@email.com", "Ethan", "Wintill", "password3", "username3", true },
                    { new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1752), "email2@email.com", "Karl", "Enriquez", "password2", "username2", true },
                    { new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1758), "email5@email.com", "John", "Doe", "password5", "username5", true },
                    { new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"), new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1756), "email4@email.com", "MyName", "IsTest", "password4", "username4", true }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "IMEI", "Manufacturer", "Model", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("2a8f20dd-ae3c-4620-a0b1-419d6f7d2ab1"), "613638575519862", "Apple", "IPhone", "5647382910", new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") },
                    { new Guid("5ecd57a5-c061-4658-adaf-309cea8d78e3"), "536773236552500", "Google", "Pixel", "1122334455", new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d") },
                    { new Guid("8312440a-6f1a-4411-916e-556d6c66795c"), "013750962836846", "Motorola", "Razr", "5544332211", new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12") },
                    { new Guid("e1a39dcc-5f9b-4a19-8cb7-9e92d099ee0c"), "464532177499263", "Samsung", "Galaxy", "9231478343", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                    { new Guid("f9c81872-0545-4028-9e99-36df82aa0604"), "400322363175433", "Apple", "IPhone", "1234567890", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                    { new Guid("fa733d84-b500-4661-8b00-e0150b42701c"), "605713007805519", "Apple", "IPhone", "8792013456", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("fcb80377-3327-4458-b86b-7f880c1984d3"), "143567321209614", "Samsung", "Galaxy", "1987654321", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") }
                });

            migrationBuilder.InsertData(
                table: "UserPlans",
                columns: new[] { "PlanId", "UserId", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"), new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"), new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_UserId",
                table: "Devices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlans_PlanId",
                table: "UserPlans",
                column: "PlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "UserPlans");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
