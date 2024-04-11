using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KEBZ_Communications.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Kar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPlans",
                table: "UserPlans");

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

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") });

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") });

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"), new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") });

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"), new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12") });

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumns: new[] { "PlanId", "UserId" },
                keyValues: new object[] { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d") });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPlans",
                table: "UserPlans",
                column: "UserPlanId");

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "IMEI", "Manufacturer", "Model", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("21f80601-eb7a-4e8b-96ea-fa8937e24bff"), "613638575519862", "Apple", "IPhone", "5647382910", new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") },
                    { new Guid("689f049f-124f-4747-a7f2-02c67bbb7550"), "013750962836846", "Motorola", "Razr", "5544332211", new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12") },
                    { new Guid("a3c61d1c-c11b-471f-ad1b-55ed81bcbd62"), "605713007805519", "Apple", "IPhone", "8792013456", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("a7867b36-c00b-471e-bddc-ed53d7abfc5f"), "143567321209614", "Samsung", "Galaxy", "1987654321", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("bb9f3f1f-0523-4ca8-8f9b-39ebdd0bd0b8"), "536773236552500", "Google", "Pixel", "1122334455", new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d") },
                    { new Guid("f92ad636-25e7-4a80-a962-cadffd368bd6"), "400322363175433", "Apple", "IPhone", "1234567890", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                    { new Guid("fcd493a3-4350-4c87-a499-02a6a8668b48"), "464532177499263", "Samsung", "Galaxy", "9231478343", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 71, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 71, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 71, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 71, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.InsertData(
                table: "UserPlans",
                columns: new[] { "UserPlanId", "EndDate", "PlanId", "StartDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("1024c3d1-45f8-4513-b63c-8d4df5b1f2b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12") },
                    { new Guid("57fc1c97-b5a1-4e9a-9b55-90906a2f2b0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2") },
                    { new Guid("a5b47a1f-e288-4c77-83b1-65334a9ba877"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798acf1b-7339-44bd-8367-7132a978d7b1") },
                    { new Guid("aaf6281f-9668-4b6d-b6bc-8de2307337f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d") },
                    { new Guid("f6a780d0-06a7-4d74-ae4d-d6fc8ff73b9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 70, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 70, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 70, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 70, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 14, 28, 70, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.CreateIndex(
                name: "IX_UserPlans_UserId",
                table: "UserPlans",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPlans",
                table: "UserPlans");

            migrationBuilder.DropIndex(
                name: "IX_UserPlans_UserId",
                table: "UserPlans");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("21f80601-eb7a-4e8b-96ea-fa8937e24bff"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("689f049f-124f-4747-a7f2-02c67bbb7550"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("a3c61d1c-c11b-471f-ad1b-55ed81bcbd62"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("a7867b36-c00b-471e-bddc-ed53d7abfc5f"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("bb9f3f1f-0523-4ca8-8f9b-39ebdd0bd0b8"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f92ad636-25e7-4a80-a962-cadffd368bd6"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("fcd493a3-4350-4c87-a499-02a6a8668b48"));

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumn: "UserPlanId",
                keyValue: new Guid("1024c3d1-45f8-4513-b63c-8d4df5b1f2b8"));

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumn: "UserPlanId",
                keyValue: new Guid("57fc1c97-b5a1-4e9a-9b55-90906a2f2b0c"));

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumn: "UserPlanId",
                keyValue: new Guid("a5b47a1f-e288-4c77-83b1-65334a9ba877"));

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumn: "UserPlanId",
                keyValue: new Guid("aaf6281f-9668-4b6d-b6bc-8de2307337f5"));

            migrationBuilder.DeleteData(
                table: "UserPlans",
                keyColumn: "UserPlanId",
                keyValue: new Guid("f6a780d0-06a7-4d74-ae4d-d6fc8ff73b9f"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPlans",
                table: "UserPlans",
                columns: new[] { "UserId", "PlanId" });

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

            migrationBuilder.InsertData(
                table: "UserPlans",
                columns: new[] { "PlanId", "UserId", "EndDate", "StartDate", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"), new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"), new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"), new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

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
    }
}
