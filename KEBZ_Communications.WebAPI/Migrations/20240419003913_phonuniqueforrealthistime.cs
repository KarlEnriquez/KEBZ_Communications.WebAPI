using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KEBZ_Communications.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class phonuniqueforrealthistime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("2d8178b1-0a6d-47ab-ac64-0db100ced2fb"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("4539cbcb-ece8-473f-9c57-45a37861c0b6"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("48981e87-7cf4-44dc-9762-218f218d93d3"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("7885f9b5-ec97-4c01-942f-b539dd1db1e1"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("bf1f5524-528e-4c5b-a543-9bdff355efca"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("c7b2e77a-154a-42a1-bf46-3addd7cba02c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("d8c7d69d-f587-4ce0-9963-4779de590cca"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Devices",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "26ced429-5778-4ba5-8467-77084aaaa721", new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "61cadfe2-1415-43c3-9822-333043bc75f3", new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "d73e7424-8a18-43b8-a282-c1af983a7ac9", new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "ef0bdd06-0866-4ac0-8cb5-f67090598f33", new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "bcfdd73b-1ace-4ff4-8f10-e23223efd413", new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "IMEI", "Manufacturer", "Model", "PhoneNumber", "UserId", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("0557d5e7-fe8a-4bb7-8ac1-bb69e817e885"), "536773236552500", "Google", "Pixel", "1122334455", new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("07ea4af4-ad14-4105-8812-48b35d458ae6"), "605713007805519", "Apple", "IPhone", "8792013456", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6aa203e5-6993-4ba6-83a8-3ee8c75302fa"), "143567321209614", "Samsung", "Galaxy", "1987654321", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b303857c-bd4e-4d05-9c22-5a60cd8e4625"), "464532177499263", "Samsung", "Galaxy", "9231478343", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("caacbdde-caec-47b8-bc87-ff74b62bf53a"), "613638575519862", "Apple", "IPhone", "5647382910", new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e889de1d-a20f-4a3e-8e45-f035a7e2fb12"), "400322363175433", "Apple", "IPhone", "1234567890", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ec6fab3d-5320-4b7c-99ae-5e22b6f4d6ba"), "013750962836846", "Motorola", "Razr", "5544332211", new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 19, 39, 13, 523, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.CreateIndex(
                name: "IX_Devices_PhoneNumber",
                table: "Devices",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Devices_PhoneNumber",
                table: "Devices");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("0557d5e7-fe8a-4bb7-8ac1-bb69e817e885"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("07ea4af4-ad14-4105-8812-48b35d458ae6"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("6aa203e5-6993-4ba6-83a8-3ee8c75302fa"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("b303857c-bd4e-4d05-9c22-5a60cd8e4625"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("caacbdde-caec-47b8-bc87-ff74b62bf53a"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("e889de1d-a20f-4a3e-8e45-f035a7e2fb12"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("ec6fab3d-5320-4b7c-99ae-5e22b6f4d6ba"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "4fe574cf-2f1f-41c7-aacb-b1d972dbfe5e", new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "b35025f5-44cc-4c91-af20-5b4a2851ea8f", new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "b52922f4-d052-49ea-b7bc-fee01d1e0be7", new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "d99f692f-6e6e-4ccc-b7c5-0c4ca86e96a6", new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "a5f6dee9-1ddc-4d90-8d3b-bed6c63933e4", new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "IMEI", "Manufacturer", "Model", "PhoneNumber", "UserId", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("2d8178b1-0a6d-47ab-ac64-0db100ced2fb"), "536773236552500", "Google", "Pixel", "1122334455", new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4539cbcb-ece8-473f-9c57-45a37861c0b6"), "613638575519862", "Apple", "IPhone", "5647382910", new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("48981e87-7cf4-44dc-9762-218f218d93d3"), "143567321209614", "Samsung", "Galaxy", "1987654321", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7885f9b5-ec97-4c01-942f-b539dd1db1e1"), "400322363175433", "Apple", "IPhone", "1234567890", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bf1f5524-528e-4c5b-a543-9bdff355efca"), "464532177499263", "Samsung", "Galaxy", "9231478343", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c7b2e77a-154a-42a1-bf46-3addd7cba02c"), "605713007805519", "Apple", "IPhone", "8792013456", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d8c7d69d-f587-4ce0-9963-4779de590cca"), "013750962836846", "Motorola", "Razr", "5544332211", new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 19, 32, 26, 725, DateTimeKind.Local).AddTicks(6800));
        }
    }
}
