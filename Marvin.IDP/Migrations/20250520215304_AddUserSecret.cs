using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSecret : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserSecrets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Secret = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecrets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecrets_Users_UserId",
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
                    { new Guid("1fe5efe0-74c6-4a5d-bf83-02b6cebd559c"), "8b070ac4-bb47-40ef-acaa-1789d4ef4850", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("28fd6240-d8cb-4553-8f61-160c583f3107"), "474b2e1d-a6d2-440f-a7bf-2158b9bc9a2a", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("2cafae66-9144-4172-9896-db40dca3ffcc"), "7743ccba-04f8-4937-83b6-b827cbcb6db7", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "br" },
                    { new Guid("80b438df-0bfa-4b1e-a39f-4fcf4e0eba2d"), "db8b7ee6-5c8a-4c87-9c1d-ba063bbb405e", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("8fbcdace-c441-4206-be5f-3a55e2c839a4"), "128cd5cf-ecf8-4375-a06b-d524d6f95956", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("ae4841cc-f67d-494f-8102-6b455845dd9c"), "c825c1a9-9f12-4d24-9867-3e285e6c0abc", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("c35ad59a-d0d6-4d21-8706-27e88d34719b"), "18ff6ef8-6436-46f1-ba4a-41ff9e310098", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("c8bd04dd-963b-4813-b724-3301b5bb3ed8"), "18696760-bf04-4173-902c-11284d3494ef", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "e5ea5d2b-df58-4124-9d53-c75669c8b13d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "b87126ed-6991-4f95-b66d-55f648771aa6");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecrets_UserId",
                table: "UserSecrets",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSecrets");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1fe5efe0-74c6-4a5d-bf83-02b6cebd559c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("28fd6240-d8cb-4553-8f61-160c583f3107"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2cafae66-9144-4172-9896-db40dca3ffcc"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("80b438df-0bfa-4b1e-a39f-4fcf4e0eba2d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8fbcdace-c441-4206-be5f-3a55e2c839a4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ae4841cc-f67d-494f-8102-6b455845dd9c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c35ad59a-d0d6-4d21-8706-27e88d34719b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c8bd04dd-963b-4813-b724-3301b5bb3ed8"));

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
    }
}
