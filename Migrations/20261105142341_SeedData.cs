using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace G_NET68_EF_Assignment_3.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[] { 1, "Software engineering and coding.", "Programming", null });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "Email", "FullName", "JoinedDate" },
                values: new object[,]
                {
                    { 1, "Senior .NET Architect with 12 years of experience.", "sarah.connor@example.com", "Sarah Connor", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Full-stack developer and cloud specialist.", "m.scott@example.com", "Michael Scott", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Frontend engineer specializing in modern JS frameworks.", "elena.rostova@example.com", "Elena Rostova", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 2, "Server-side architecture and APIs.", "Backend", 1 },
                    { 5, "Client-side interfaces and web UI.", "Frontend", 1 },
                    { 3, "Modern C# web development with .NET.", "ASP.NET Core", 2 },
                    { 4, "Backend JavaScript runtime environment.", "Node.js", 2 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 5, 5, "HTML, CSS, and modern JavaScript fundamentals.", 3, true, "Beginner", 29.99m, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern Frontend Basics" },
                    { 6, 2, "Unpublished comprehensive backend course.", 3, false, "Intermediate", 99.99m, null, "Full-stack Backend Mastery (Upcoming)" },
                    { 1, 3, "Learn REST API development with C#.", 1, true, "Beginner", 49.99m, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET Core Web API Fundamentals" },
                    { 2, 3, "Master DDD and performance optimization in EF Core.", 1, true, "Advanced", 89.99m, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advanced Entity Framework Core Patterns" },
                    { 3, 4, "Build scalable event-driven systems with Node.js.", 2, true, "Intermediate", 69.99m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Node.js Microservices Architecture" },
                    { 4, 4, "Unpublished guide to memory leaks and profiling.", 2, false, "Advanced", 39.99m, null, "Node.js Performance Tuning (Draft)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
