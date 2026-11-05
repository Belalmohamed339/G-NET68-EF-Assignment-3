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
    internal class InstructorConfigs : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.FullName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(i => i.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(i => i.Bio)
                .HasMaxLength(1000);

            builder.Property(i => i.JoinedDate)
                .IsRequired();

            builder.HasMany(i => i.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.Cascade);



            builder.HasData(
            new Instructor
            {
                Id = 1,
                FullName = "Sarah Connor",
                Email = "sarah.connor@example.com",
                Bio = "Senior .NET Architect with 12 years of experience.",
                JoinedDate = new DateTime(2021, 1, 15)
            },
            new Instructor
            {
                Id = 2,
                FullName = "Michael Scott",
                Email = "m.scott@example.com",
                Bio = "Full-stack developer and cloud specialist.",
                JoinedDate = new DateTime(2022, 5, 20)
            },
            new Instructor
            {
                Id = 3,
                FullName = "Elena Rostova",
                Email = "elena.rostova@example.com",
                Bio = "Frontend engineer specializing in modern JS frameworks.",
                JoinedDate = new DateTime(2023, 3, 10)
            }
            );
            
        }



    }
}
