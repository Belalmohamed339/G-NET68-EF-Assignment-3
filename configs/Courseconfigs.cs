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
        }
    }
}
