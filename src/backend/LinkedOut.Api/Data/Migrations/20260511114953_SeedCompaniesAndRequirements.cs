using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkedOut.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompaniesAndRequirements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "location", "name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-000000000001"), "Ukraine", "Tech Corp" },
                    { new Guid("11111111-1111-1111-1111-000000000002"), "Ukraine", "SoftServe" },
                    { new Guid("11111111-1111-1111-1111-000000000003"), "Ukraine", "GlobalLogic" },
                    { new Guid("11111111-1111-1111-1111-000000000004"), "Ukraine", "EPAM" },
                    { new Guid("11111111-1111-1111-1111-000000000005"), "Ukraine", "Infopulse" },
                    { new Guid("11111111-1111-1111-1111-000000000006"), "Ukraine", "Luxoft" },
                    { new Guid("11111111-1111-1111-1111-000000000007"), "Ukraine", "Ciklum" },
                    { new Guid("11111111-1111-1111-1111-000000000008"), "Ukraine", "Genesis" }
                });

            migrationBuilder.InsertData(
                table: "requirements",
                columns: new[] { "id", "company_id", "title" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-000000000001"), new Guid("11111111-1111-1111-1111-000000000001"), "Fullstack Developer" },
                    { new Guid("22222222-2222-2222-2222-000000000002"), new Guid("11111111-1111-1111-1111-000000000001"), "Backend Engineer" },
                    { new Guid("22222222-2222-2222-2222-000000000003"), new Guid("11111111-1111-1111-1111-000000000002"), "Fullstack Developer" },
                    { new Guid("22222222-2222-2222-2222-000000000004"), new Guid("11111111-1111-1111-1111-000000000002"), "Backend Engineer" },
                    { new Guid("22222222-2222-2222-2222-000000000005"), new Guid("11111111-1111-1111-1111-000000000003"), "Fullstack Developer" },
                    { new Guid("22222222-2222-2222-2222-000000000006"), new Guid("11111111-1111-1111-1111-000000000003"), "Backend Engineer" },
                    { new Guid("22222222-2222-2222-2222-000000000007"), new Guid("11111111-1111-1111-1111-000000000004"), "Fullstack Developer" },
                    { new Guid("22222222-2222-2222-2222-000000000008"), new Guid("11111111-1111-1111-1111-000000000004"), "Backend Engineer" },
                    { new Guid("22222222-2222-2222-2222-000000000009"), new Guid("11111111-1111-1111-1111-000000000005"), "Fullstack Developer" },
                    { new Guid("22222222-2222-2222-2222-000000000010"), new Guid("11111111-1111-1111-1111-000000000005"), "Backend Engineer" },
                    { new Guid("22222222-2222-2222-2222-000000000011"), new Guid("11111111-1111-1111-1111-000000000006"), "Fullstack Developer" },
                    { new Guid("22222222-2222-2222-2222-000000000012"), new Guid("11111111-1111-1111-1111-000000000006"), "Backend Engineer" },
                    { new Guid("22222222-2222-2222-2222-000000000013"), new Guid("11111111-1111-1111-1111-000000000007"), "Fullstack Developer" },
                    { new Guid("22222222-2222-2222-2222-000000000014"), new Guid("11111111-1111-1111-1111-000000000007"), "Backend Engineer" },
                    { new Guid("22222222-2222-2222-2222-000000000015"), new Guid("11111111-1111-1111-1111-000000000008"), "Fullstack Developer" },
                    { new Guid("22222222-2222-2222-2222-000000000016"), new Guid("11111111-1111-1111-1111-000000000008"), "Backend Engineer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"));

            migrationBuilder.DeleteData(
                table: "requirements",
                keyColumn: "id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000001"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000002"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000003"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000004"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000005"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000006"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000007"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("11111111-1111-1111-1111-000000000008"));
        }
    }
}
