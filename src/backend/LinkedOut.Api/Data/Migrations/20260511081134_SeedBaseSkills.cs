using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinkedOut.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedBaseSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "skills",
                columns: new[] { "id", "category", "name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Backend", ".NET" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Backend", "C#" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Backend", "SQL" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Backend", "PostgreSQL" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Frontend", "Angular" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Frontend", "TypeScript" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Infrastructure", "Docker" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Infrastructure", "Git" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Infrastructure", "Azure" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Infrastructure", "AWS" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Infrastructure", "Unit Testing" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Infrastructure", "CI/CD" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));
        }
    }
}
