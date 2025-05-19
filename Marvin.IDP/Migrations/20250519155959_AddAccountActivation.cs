using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("171ce1cb-7cf0-4b12-a4e3-393487252a28"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5fb3f954-5aed-4679-ace1-f9b458fe2c67"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("729b3ec1-3620-4813-a960-cbd21ec8984c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("76dedae2-81b4-4e2d-b7e2-55ba2bf62f81"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("808eb15e-f159-4628-9ea7-6b1be3171483"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("bfe2b666-3e17-46fe-8af5-58abca68c412"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("dd661370-65d0-448e-ba95-c2356ba9b898"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e304d186-9c57-4fe5-8c36-10936581e8a7"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("01061600-9545-47d9-a540-116a952d135e"), "a23384a1-1a45-413f-86fa-2bc3a96c364c", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("45fa0372-2bf5-4000-8dc9-cd3f4d07b0eb"), "690cfd8a-b368-4815-9fb9-0577c5d1f0d0", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("4fecf7ac-8736-45aa-adee-95975b523d30"), "62220cce-1b55-4bc3-a06c-38ae46cfc4bf", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("533725b0-6d8c-4935-871e-0b003f22005e"), "f9a7df24-808c-48f2-82ba-8e12a03a1a53", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("64afc068-b7c2-4fb4-9898-28a034626f2b"), "4310a45f-9ac2-428c-ba52-6af8ef940e2a", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("6db72d51-e573-498e-9de1-0ed3bb3e7242"), "e79cf3c3-e0d4-489e-bcdd-12e8cdf0422b", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("c7892a81-b11e-47d1-b92d-27433a06eb15"), "a5cb45b1-06d4-4dab-a0a0-e958100c18e5", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "br" },
                    { new Guid("edf1178c-d4ae-4db9-86b0-50aff3793ca9"), "ae1e462c-e3fd-4031-9dca-8e95cd469a48", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "2f4d9ea8-ce8c-420d-b55e-e827776cd0e0", "david@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "1462e5d5-1edd-430c-bc70-f7ae72cad2a9", "emma@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("01061600-9545-47d9-a540-116a952d135e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("45fa0372-2bf5-4000-8dc9-cd3f4d07b0eb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4fecf7ac-8736-45aa-adee-95975b523d30"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("533725b0-6d8c-4935-871e-0b003f22005e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("64afc068-b7c2-4fb4-9898-28a034626f2b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6db72d51-e573-498e-9de1-0ed3bb3e7242"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c7892a81-b11e-47d1-b92d-27433a06eb15"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("edf1178c-d4ae-4db9-86b0-50aff3793ca9"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("171ce1cb-7cf0-4b12-a4e3-393487252a28"), "256d5986-b0ec-4dda-b7ef-1abbea61e750", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("5fb3f954-5aed-4679-ace1-f9b458fe2c67"), "295640a7-ae2e-41cd-aeb8-8e2975e2b6f6", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("729b3ec1-3620-4813-a960-cbd21ec8984c"), "ebc9dcd0-487f-4b87-bbf7-b7096fc8f217", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("76dedae2-81b4-4e2d-b7e2-55ba2bf62f81"), "9a47bad7-6697-440e-b312-aff86e77eb55", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("808eb15e-f159-4628-9ea7-6b1be3171483"), "f7bbcaf3-0735-44c2-9c19-2caf6d3bc34c", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("bfe2b666-3e17-46fe-8af5-58abca68c412"), "4e43e123-fd47-4d9e-bc09-a34269ce878d", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "br" },
                    { new Guid("dd661370-65d0-448e-ba95-c2356ba9b898"), "1bc6b155-4aaa-4e00-97d8-5f0a4565a4df", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("e304d186-9c57-4fe5-8c36-10936581e8a7"), "b8428bda-711d-4c5a-a706-3673e0cd3ff9", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "7df78827-9b28-49f5-b5ba-bbc52a9a4997");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "63045674-d4e9-48d2-8a4b-ba9443466666");
        }
    }
}
