using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KEBZ_Communications.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Karl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("2a8f20dd-ae3c-4620-a0b1-419d6f7d2ab1"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("5ecd57a5-c061-4658-adaf-309cea8d78e3"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("8312440a-6f1a-4411-916e-556d6c66795c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("e1a39dcc-5f9b-4a19-8cb7-9e92d099ee0c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f9c81872-0545-4028-9e99-36df82aa0604"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("fa733d84-b500-4661-8b00-e0150b42701c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("fcb80377-3327-4458-b86b-7f880c1984d3"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserPlanId",
                table: "UserPlans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "IMEI", "Manufacturer", "Model", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("2fece41e-6625-4da9-8c00-5345737bdc8a"), "613638575519862", "Apple", "IPhone", "5647382910", new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") },
                    { new Guid("3ee47975-cd69-464b-b46c-5fd444de1ab3"), "605713007805519", "Apple", "IPhone", "8792013456", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("4c1bebc7-0397-402a-a900-e879be46c865"), "013750962836846", "Motorola", "Razr", "5544332211", new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12") },
                    { new Guid("7a73e038-4bc6-4f0e-bc03-8e135a2266f6"), "536773236552500", "Google", "Pixel", "1122334455", new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d") },
                    { new Guid("82e2d236-ff60-43ab-9683-d371a8618548"), "464532177499263", "Samsung", "Galaxy", "9231478343", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                    { new Guid("9031f9ab-a03c-4f89-8da3-e2c9186e6912"), "400322363175433", "Apple", "IPhone", "1234567890", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                    { new Guid("c4977d44-030d-4278-aa13-179976da44ae"), "143567321209614", "Samsung", "Galaxy", "1987654321", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                column: "UserPlanId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") },
                column: "UserPlanId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"), new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                column: "UserPlanId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"), new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12") },
                column: "UserPlanId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d") },
                column: "UserPlanId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 15, 26, 32, 452, DateTimeKind.Local).AddTicks(4737));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("2fece41e-6625-4da9-8c00-5345737bdc8a"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("3ee47975-cd69-464b-b46c-5fd444de1ab3"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("4c1bebc7-0397-402a-a900-e879be46c865"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("7a73e038-4bc6-4f0e-bc03-8e135a2266f6"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("82e2d236-ff60-43ab-9683-d371a8618548"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("9031f9ab-a03c-4f89-8da3-e2c9186e6912"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("c4977d44-030d-4278-aa13-179976da44ae"));

            migrationBuilder.DropColumn(
                name: "UserPlanId",
                table: "UserPlans");

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

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1756));
        }
    }
}
