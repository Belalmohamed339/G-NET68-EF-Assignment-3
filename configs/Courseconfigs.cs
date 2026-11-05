using G_NET68_EF_Assignment_3.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_3.configs
{
    internal class Courseconfigs : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .HasMaxLength(2000);

            builder.Property(c => c.Price)
                .HasPrecision(18, 2);

            builder.Property(c => c.Level)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(c => c.IsPublished)
                .IsRequired();

            builder.Property(c => c.PublishedDate)
                .IsRequired(false);



            builder.HasData(
            new Course
            {
                Id = 1,
                Title = "ASP.NET Core Web API Fundamentals",
                Description = "Learn REST API development with C#.",
                Price = 49.99m,
                Level = CourseLevel.Beginner,
                IsPublished = true,
                PublishedDate = new DateTime(2023, 6, 1),
                InstructorId = 1,
                CategoryId = 3 // ASP.NET Core
            },
            new Course
            {
                Id = 2,
                Title = "Advanced Entity Framework Core Patterns",
                Description = "Master DDD and performance optimization in EF Core.",
                Price = 89.99m,
                Level = CourseLevel.Advanced,
                IsPublished = true,
                PublishedDate = new DateTime(2023, 8, 15),
                InstructorId = 1,
                CategoryId = 3 // ASP.NET Core
            },
            new Course
            {
                Id = 3,
                Title = "Node.js Microservices Architecture",
                Description = "Build scalable event-driven systems with Node.js.",
                Price = 69.99m,
                Level = CourseLevel.Intermediate,
                IsPublished = true,
                PublishedDate = new DateTime(2024, 2, 10),
                InstructorId = 2,
                CategoryId = 4 // Node.js
            },
            new Course
            {
                Id = 4,
                Title = "Node.js Performance Tuning (Draft)",
                Description = "Unpublished guide to memory leaks and profiling.",
                Price = 39.99m,
                Level = CourseLevel.Advanced,
                IsPublished = false,
                PublishedDate = null,
                InstructorId = 2,
                CategoryId = 4 // Node.js
            },
            new Course
            {
                Id = 5,
                Title = "Modern Frontend Basics",
                Description = "HTML, CSS, and modern JavaScript fundamentals.",
                Price = 29.99m,
                Level = CourseLevel.Beginner,
                IsPublished = true,
                PublishedDate = new DateTime(2024, 1, 5),
                InstructorId = 3,
                CategoryId = 5 // Frontend
            },
            new Course
            {
                Id = 6,
                Title = "Full-stack Backend Mastery (Upcoming)",
                Description = "Unpublished comprehensive backend course.",
                Price = 99.99m,
                Level = CourseLevel.Intermediate,
                IsPublished = false,
                PublishedDate = null,
                InstructorId = 3,
                CategoryId = 2 // Backend
            }
        );
        }
    }
}
