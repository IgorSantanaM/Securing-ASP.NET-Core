using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddUserLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Provider = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

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
                column: "ConcurrencyStamp",
                value: "2f4d9ea8-ce8c-420d-b55e-e827776cd0e0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "1462e5d5-1edd-430c-bc70-f7ae72cad2a9");
        }
    }
}
