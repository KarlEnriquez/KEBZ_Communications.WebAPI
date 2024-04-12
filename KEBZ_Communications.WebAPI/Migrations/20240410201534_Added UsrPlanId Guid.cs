using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KEBZ_Communications.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedUsrPlanIdGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 16, 15, 33, 701, DateTimeKind.Local).AddTicks(4320));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
