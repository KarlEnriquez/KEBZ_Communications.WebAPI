using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KEBZ_Communications.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class uniquephone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Devices",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_PhoneNumber",
                table: "Devices",
                column: "PhoneNumber");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "f69a52d9-1f9b-4fe5-9861-567591373a44", new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "46b40560-adfe-4817-81c2-d8b31108fa00", new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "a17b6dfe-3c9e-4bb7-a598-5e72a866b0dd", new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "61dc4b8e-307f-441e-9b5e-e2106f23a0ca", new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "909905cd-e415-4e1a-bbe8-340bdb42f363", new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "IMEI", "Manufacturer", "Model", "PhoneNumber", "UserId", "UserPlanId" },
                values: new object[,]
                {
                    { new Guid("072ee987-01d2-4a91-998d-b85e89220b23"), "143567321209614", "Samsung", "Galaxy", "1987654321", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1c2359b2-1d5f-4e5a-89d0-4a40819ccd67"), "464532177499263", "Samsung", "Galaxy", "9231478343", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("25673bd8-2adc-4350-978c-6b2ff930ba54"), "536773236552500", "Google", "Pixel", "1122334455", new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("80f7a55d-4f0e-4a2a-9ace-b6a74291e82c"), "605713007805519", "Apple", "IPhone", "8792013456", new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8fdd490a-cdfe-4ff5-950d-0917ace8c23c"), "613638575519862", "Apple", "IPhone", "5647382910", new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d380f3a2-8991-4e10-98da-4d265ecaf916"), "400322363175433", "Apple", "IPhone", "1234567890", new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f6608b77-58c8-4597-948c-a8b50ec30846"), "013750962836846", "Motorola", "Razr", "5544332211", new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 34, 244, DateTimeKind.Local).AddTicks(7270));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_PhoneNumber",
                table: "Devices");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("072ee987-01d2-4a91-998d-b85e89220b23"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("1c2359b2-1d5f-4e5a-89d0-4a40819ccd67"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("25673bd8-2adc-4350-978c-6b2ff930ba54"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("80f7a55d-4f0e-4a2a-9ace-b6a74291e82c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("8fdd490a-cdfe-4ff5-950d-0917ace8c23c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("d380f3a2-8991-4e10-98da-4d265ecaf916"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: new Guid("f6608b77-58c8-4597-948c-a8b50ec30846"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Password" },
                values: new object[] { "a5234556-a54d-4306-a98f-fe47459b8d9f", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1430), "password1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Password" },
                values: new object[] { "210a3544-c963-4091-a39a-7fbde5894de5", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1500), "password3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Password" },
                values: new object[] { "c1d33a44-e9cb-4351-bc34-ca65db880453", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1490), "password2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Password" },
                values: new object[] { "36a295a6-72aa-41db-9b89-b2e5e28d4231", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1520), "password5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Password" },
                values: new object[] { "970d377f-ee83-41a9-a506-da74052d578b", new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1510), "password4" });

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
    }
}
