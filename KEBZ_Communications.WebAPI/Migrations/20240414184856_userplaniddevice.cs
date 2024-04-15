using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KEBZ_Communications.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class userplaniddevice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("07115c2a-ab2f-4777-87b5-7dc33e1596e6"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("2ec741fa-64a9-496c-a0aa-d873a1efcbb3"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("57a38da1-427c-4121-a93c-697d9396c788"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("63a68637-a178-4de5-8b21-0aeb0d3db7aa"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("682cd6aa-33fa-47e4-afca-bd3055cbe6d1"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("80015f77-8255-47f3-9e1c-bdaf5f0f70c7"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("8b9cf0db-c76d-47b3-b9bb-310933c77876"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserPlanId",
                table: "Devices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "a5234556-a54d-4306-a98f-fe47459b8d9f", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "210a3544-c963-4091-a39a-7fbde5894de5", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "c1d33a44-e9cb-4351-bc34-ca65db880453", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "36a295a6-72aa-41db-9b89-b2e5e28d4231", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "970d377f-ee83-41a9-a506-da74052d578b", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "IMEI", "Manufacturer", "Model", "PhoneNumber", "UserId", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("46778fee-73cd-46d3-8432-063e42b419e4"), "536773236552500", "Google", "Pixel", "1122334455", new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("770c4356-3ddb-417f-bcdb-cfb694bf51b6"), "464532177499263", "Samsung", "Galaxy", "9231478343", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("836f99d4-43ca-4bd1-82f1-38dce36be77c"), "613638575519862", "Apple", "IPhone", "5647382910", new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("83f872ec-3173-4ed9-9290-a816848df6af"), "605713007805519", "Apple", "IPhone", "8792013456", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8cb627dd-f70d-4606-b903-d21a9eee14f6"), "143567321209614", "Samsung", "Galaxy", "1987654321", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8f8ce237-2976-48b3-b740-a100299579ae"), "400322363175433", "Apple", "IPhone", "1234567890", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cf096677-6e6f-4607-8d5e-e43da3afab05"), "013750962836846", "Motorola", "Razr", "5544332211", new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1630));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("46778fee-73cd-46d3-8432-063e42b419e4"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("770c4356-3ddb-417f-bcdb-cfb694bf51b6"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("836f99d4-43ca-4bd1-82f1-38dce36be77c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("83f872ec-3173-4ed9-9290-a816848df6af"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("8cb627dd-f70d-4606-b903-d21a9eee14f6"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("8f8ce237-2976-48b3-b740-a100299579ae"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("cf096677-6e6f-4607-8d5e-e43da3afab05"));

            migrationBuilder.DropColumn(
                name: "UserPlanId",
                table: "Devices");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "d2b28b2d-6244-4f0b-a045-00411ccd7226", new DateTime(2024, 4, 11, 14, 46, 44, 734, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "e07d36a6-e7d6-4136-aaac-0869aa59eb52", new DateTime(2024, 4, 11, 14, 46, 44, 734, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "f893acca-c455-445f-94b2-4c2539449ee0", new DateTime(2024, 4, 11, 14, 46, 44, 734, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "d9051bd0-42f8-4b94-b838-6838a661950d", new DateTime(2024, 4, 11, 14, 46, 44, 734, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "582c4021-500c-4a2b-a043-4ddf02f7047c", new DateTime(2024, 4, 11, 14, 46, 44, 734, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "IMEI", "Manufacturer", "Model", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("07115c2a-ab2f-4777-87b5-7dc33e1596e6"), "400322363175433", "Apple", "IPhone", "1234567890", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                    { new Guid("2ec741fa-64a9-496c-a0aa-d873a1efcbb3"), "605713007805519", "Apple", "IPhone", "8792013456", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("57a38da1-427c-4121-a93c-697d9396c788"), "143567321209614", "Samsung", "Galaxy", "1987654321", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("63a68637-a178-4de5-8b21-0aeb0d3db7aa"), "464532177499263", "Samsung", "Galaxy", "9231478343", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                    { new Guid("682cd6aa-33fa-47e4-afca-bd3055cbe6d1"), "613638575519862", "Apple", "IPhone", "5647382910", new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") },
                    { new Guid("80015f77-8255-47f3-9e1c-bdaf5f0f70c7"), "013750962836846", "Motorola", "Razr", "5544332211", new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12") },
                    { new Guid("8b9cf0db-c76d-47b3-b9bb-310933c77876"), "536773236552500", "Google", "Pixel", "1122334455", new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d") }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4916));
        }
    }
}
