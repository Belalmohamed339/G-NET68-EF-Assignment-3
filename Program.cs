using G_NET68_EF_Assignment_3.dbContext;
using G_NET68_EF_Assignment_3.models;
using Microsoft.EntityFrameworkCore;

namespace G_NET68_EF_Assignment_3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            using DbContext dbContext = new AppDbcontext();
            await dbContext.Database.MigrateAsync();
            if (!await dbContext.Set<Student>().AnyAsync())
            {
                var students = new List<Student>
        {
            new Student { FullName = "Alice Smith", Email = "alice@example.com", DateOfBirth = new DateTime(1998, 4, 12) },
            new Student { FullName = "Bob Johnson", Email = "bob@example.com", DateOfBirth = new DateTime(1995, 9, 23) },
            new Student { FullName = "Charlie Davis", Email = "charlie@example.com", DateOfBirth = new DateTime(2001, 1, 30) },
            new Student { FullName = "Diana Prince", Email = "diana@example.com", DateOfBirth = new DateTime(1997, 11, 5) },
            new Student { FullName = "Ethan Hunt", Email = "ethan@example.com", DateOfBirth = new DateTime(1999, 7, 18) }
        };

                await dbContext.Set<Student>().AddRangeAsync(students);
                await dbContext.SaveChangesAsync();
            }

            if (!await dbContext.Set<Enrollment>().AnyAsync())
            {
                var students = await dbContext.Set<Student>().ToListAsync();

                var enrollments = new List<Enrollment>
        {
            new Enrollment
            {
                StudentId = students[0].Id,
                CourseId = 1,
                EnrollmentDate = new DateTime(2024, 1, 10),
                ProgressPercentage = 100m,
                Status = EnrollmentStatus.Completed,
                FinalGrade = 95.5m
            },
            new Enrollment
            {
                StudentId = students[1].Id,
                CourseId = 5,
                EnrollmentDate = new DateTime(2024, 2, 1),
                ProgressPercentage = 100m,
                Status = EnrollmentStatus.Completed,
                FinalGrade = 88.0m
            },
            new Enrollment
            {
                StudentId = students[0].Id,
                CourseId = 2,
                EnrollmentDate = new DateTime(2024, 3, 15),
                ProgressPercentage = 45.0m,
                Status = EnrollmentStatus.Active
            },
            new Enrollment
            {
                StudentId = students[2].Id,
                CourseId = 1,
                EnrollmentDate = new DateTime(2024, 4, 2),
                ProgressPercentage = 10.0m,
                Status = EnrollmentStatus.Active
            },
            new Enrollment
            {
                StudentId = students[3].Id,
                CourseId = 3,
                EnrollmentDate = new DateTime(2024, 3, 20),
                ProgressPercentage = 75.0m,
                Status = EnrollmentStatus.Active
            },
            new Enrollment
            {
                StudentId = students[4].Id,
                CourseId = 5,
                EnrollmentDate = new DateTime(2024, 4, 10),
                ProgressPercentage = 0.0m,
                Status = EnrollmentStatus.Active
            },
            new Enrollment
            {
                StudentId = students[1].Id,
                CourseId = 3,
                EnrollmentDate = new DateTime(2024, 2, 15),
                ProgressPercentage = 20.0m,
                Status = EnrollmentStatus.Dropped
            },
            new Enrollment
            {
                StudentId = students[2].Id,
                CourseId = 2,
                EnrollmentDate = new DateTime(2024, 3, 1),
                ProgressPercentage = 5.0m,
                Status = EnrollmentStatus.Dropped
            }
        };
                await dbContext.Set<Enrollment>().AddRangeAsync(enrollments);
                await dbContext.SaveChangesAsync();

            }
        }
    }
}
