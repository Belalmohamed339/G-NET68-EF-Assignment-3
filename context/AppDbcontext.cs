using G_NET68_EF_Assignment_3.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_3.dbContext
{
    public class AppDbcontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CC62RI3\\SQLEXPRESS;Database=OnlineLearning;Trusted_Connection=True;TrustServerCertificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Course>(new configs.Courseconfigs());
            modelBuilder.ApplyConfiguration<Student>(new configs.Studentconfigs());
            modelBuilder.ApplyConfiguration<Enrollment>(new configs.Enrollmentconfigs());
            modelBuilder.ApplyConfiguration<Instructor>(new configs.InstructorConfigs());
            modelBuilder.ApplyConfiguration<Category>(new configs.Categoryconfigs());

        }

    }
}
