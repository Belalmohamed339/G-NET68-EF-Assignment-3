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
    internal class Categoryconfigs : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Description)
                .HasMaxLength(500);

            builder.HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.HasMany(c => c.Courses)
                .WithOne(co => co.Category)
                .HasForeignKey(co => co.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
            new Category { Id = 1, Name = "Programming", Description = "Software engineering and coding.", ParentCategoryId = null },
            new Category { Id = 2, Name = "Backend", Description = "Server-side architecture and APIs.", ParentCategoryId = 1 },
            new Category { Id = 3, Name = "ASP.NET Core", Description = "Modern C# web development with .NET.", ParentCategoryId = 2 },
            new Category { Id = 4, Name = "Node.js", Description = "Backend JavaScript runtime environment.", ParentCategoryId = 2 },
            new Category { Id = 5, Name = "Frontend", Description = "Client-side interfaces and web UI.", ParentCategoryId = 1 }
        );
        }
    }
}
