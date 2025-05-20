using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class EnableNullableUserNamePasswordEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1be54279-e947-4f14-a466-fe0249348a6a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("461736c9-2680-4e6d-ba85-8976d52877aa"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5e1d7698-e232-445b-a5f5-d077d4b9fa64"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("85d25c60-24d1-4c58-93c9-eb7db70ef375"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("90c77028-768f-46d1-af90-a3986d7432c5"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a3fd7a49-f894-4456-8e5d-3b8afc7a2655"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("dd4d409e-5c8a-4f7e-b909-343f424c0cd8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fa56c807-c6b6-49a6-ac83-654ae5a0ab24"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("15e10790-7674-4720-90d6-c4a8c19ff08d"), "c0d235d0-30b6-43ad-bb71-0a735efb8826", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "br" },
                    { new Guid("45a84cbe-2a13-46cc-8d75-6cae56efb688"), "27a490b7-d885-4f80-b1cf-3832feaefea2", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("4b6d6499-05c5-4363-b1b9-568790161f22"), "e28d7b28-5116-4759-8257-ccb0c560db1e", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("787c447d-8613-454f-87e2-c6baad2c73d0"), "9517bffb-3807-4c1a-8355-ed377e251bb7", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("90d33dec-8147-40a5-9fdb-814d71c32712"), "d84ae8e6-60d1-4039-b60f-d918432abf7a", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("cd29f9d5-3647-4e67-a38a-fe4d6ba9b378"), "856343ce-aed9-45d9-99bd-7526b0369945", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("df4494e8-179a-4d43-b56a-5e349937b272"), "f3d94069-6c2d-4fa7-abf9-3f35725a8319", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("ed6f500d-85af-4927-bdc1-00e402fdfdac"), "7ab18517-70b3-4169-a3aa-9c776c76b231", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "8ce0fc83-03ec-4a6a-ab06-4fbad79c72e5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "5e0ea386-3cb2-42d7-88c5-f2988b9d9da6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("15e10790-7674-4720-90d6-c4a8c19ff08d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("45a84cbe-2a13-46cc-8d75-6cae56efb688"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4b6d6499-05c5-4363-b1b9-568790161f22"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("787c447d-8613-454f-87e2-c6baad2c73d0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("90d33dec-8147-40a5-9fdb-814d71c32712"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("cd29f9d5-3647-4e67-a38a-fe4d6ba9b378"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("df4494e8-179a-4d43-b56a-5e349937b272"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ed6f500d-85af-4927-bdc1-00e402fdfdac"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("1be54279-e947-4f14-a466-fe0249348a6a"), "745e7fed-18ab-4f4d-bb0a-2557a3f624ad", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "br" },
                    { new Guid("461736c9-2680-4e6d-ba85-8976d52877aa"), "540c4a84-a441-47ba-8792-f60996b78fc4", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("5e1d7698-e232-445b-a5f5-d077d4b9fa64"), "f3294a4a-591d-4452-8f01-20d8b90fc766", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("85d25c60-24d1-4c58-93c9-eb7db70ef375"), "70944db2-9b58-4e89-8be8-4e4ec19ac2e8", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("90c77028-768f-46d1-af90-a3986d7432c5"), "d1e16993-615d-4154-9724-cb0012fc1058", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("a3fd7a49-f894-4456-8e5d-3b8afc7a2655"), "20bad66f-30ba-41f3-bd53-f7d5ce68c154", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("dd4d409e-5c8a-4f7e-b909-343f424c0cd8"), "dc1b27b3-b6a8-4fa1-b96e-90add0c3627e", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("fa56c807-c6b6-49a6-ac83-654ae5a0ab24"), "34f4a66c-26b8-40e3-82fd-d24dfbb6d7ca", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "8297e168-e26b-4880-83d5-db176884b246");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "4b7a3c4d-5d30-4bae-8ddc-9eef267e6273");
        }
    }
}
