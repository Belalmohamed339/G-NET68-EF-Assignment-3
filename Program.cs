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
            #region seedData
            ////    await dbContext.Database.MigrateAsync();
            ////    if (!await dbContext.Set<Student>().AnyAsync())
            ////    {
            ////        var students = new List<Student>
            ////{
            ////    new Student { FullName = "Alice Smith", Email = "alice@example.com", DateOfBirth = new DateTime(1998, 4, 12) },
            ////    new Student { FullName = "Bob Johnson", Email = "bob@example.com", DateOfBirth = new DateTime(1995, 9, 23) },
            ////    new Student { FullName = "Charlie Davis", Email = "charlie@example.com", DateOfBirth = new DateTime(2001, 1, 30) },
            ////    new Student { FullName = "Diana Prince", Email = "diana@example.com", DateOfBirth = new DateTime(1997, 11, 5) },
            ////    new Student { FullName = "Ethan Hunt", Email = "ethan@example.com", DateOfBirth = new DateTime(1999, 7, 18) }
            ////};

            ////        await dbContext.Set<Student>().AddRangeAsync(students);
            ////        await dbContext.SaveChangesAsync();
            ////    }

            ////    if (!await dbContext.Set<Enrollment>().AnyAsync())
            ////    {
            ////        var students = await dbContext.Set<Student>().ToListAsync();

            ////        var enrollments = new List<Enrollment>
            ////{
            ////    new Enrollment
            ////    {
            ////        StudentId = students[0].Id,
            ////        CourseId = 1,
            ////        EnrollmentDate = new DateTime(2024, 1, 10),
            ////        ProgressPercentage = 100m,
            ////        Status = EnrollmentStatus.Completed,
            ////        FinalGrade = 95.5m
            ////    },
            ////    new Enrollment
            ////    {
            ////        StudentId = students[1].Id,
            ////        CourseId = 5,
            ////        EnrollmentDate = new DateTime(2024, 2, 1),
            ////        ProgressPercentage = 100m,
            ////        Status = EnrollmentStatus.Completed,
            ////        FinalGrade = 88.0m
            ////    },
            ////    new Enrollment
            ////    {
            ////        StudentId = students[0].Id,
            ////        CourseId = 2,
            ////        EnrollmentDate = new DateTime(2024, 3, 15),
            ////        ProgressPercentage = 45.0m,
            ////        Status = EnrollmentStatus.Active
            ////    },
            ////    new Enrollment
            ////    {
            ////        StudentId = students[2].Id,
            ////        CourseId = 1,
            ////        EnrollmentDate = new DateTime(2024, 4, 2),
            ////        ProgressPercentage = 10.0m,
            ////        Status = EnrollmentStatus.Active
            ////    },
            ////    new Enrollment
            ////    {
            ////        StudentId = students[3].Id,
            ////        CourseId = 3,
            ////        EnrollmentDate = new DateTime(2024, 3, 20),
            ////        ProgressPercentage = 75.0m,
            ////        Status = EnrollmentStatus.Active
            ////    },
            ////    new Enrollment
            ////    {
            ////        StudentId = students[4].Id,
            ////        CourseId = 5,
            ////        EnrollmentDate = new DateTime(2024, 4, 10),
            ////        ProgressPercentage = 0.0m,
            ////        Status = EnrollmentStatus.Active
            ////    },
            ////    new Enrollment
            ////    {
            ////        StudentId = students[1].Id,
            ////        CourseId = 3,
            ////        EnrollmentDate = new DateTime(2024, 2, 15),
            ////        ProgressPercentage = 20.0m,
            ////        Status = EnrollmentStatus.Dropped
            ////    },
            ////    new Enrollment
            ////    {
            ////        StudentId = students[2].Id,
            ////        CourseId = 2,
            ////        EnrollmentDate = new DateTime(2024, 3, 1),
            ////        ProgressPercentage = 5.0m,
            ////        Status = EnrollmentStatus.Dropped
            ////    }
            ////};
            ////        await dbContext.Set<Enrollment>().AddRangeAsync(enrollments);
            ////        await dbContext.SaveChangesAsync();

            ////    } 
            #endregion


            #region Create
            await dbContext.Set<Instructor>().AddAsync(new Instructor
            {
                FullName = "John Doe",
                Email = "john.doe@example.com"
            });

            Console.WriteLine("Instructor added successfully.");
            dbContext.SaveChanges();
            int instructorId = dbContext.Set<Instructor>().FirstOrDefault(i => i.Email == "john.doe@example.com")?.Id ?? 0;
            Console.WriteLine($"Instructor ID: {instructorId}");

            //var newcourse= await dbContext.Set<Course>().AddAsync(new Course
            // {
            //     Title = "Introduction to C++",
            //     Description = "Learn the basics of C# programming.",
            //     Level = CourseLevel.Beginner,
            //     InstructorId = 10,
            //     CategoryId = 10
            // });
            // bool instuctorexist = await dbContext.Set<Instructor>().AnyAsync(i => i.Id == newcourse.Entity.InstructorId);
            // bool categoryecists = await dbContext.Set<Category>().AnyAsync(c => c.Id == newcourse.Entity.CategoryId);
            // if (instuctorexist && categoryecists) {
            //     dbContext.SaveChanges(); } else { Console.WriteLine("Instructor or category not exist"); }
            // ;



            //        var students = new List<Student>
            //{
            //    new Student { FullName = "Alex Turner", Email = "alex@example.com", DateOfBirth = new DateTime(2000, 5, 12) },
            //    new Student { FullName = "Bella Hadid", Email = "bella@example.com", DateOfBirth = new DateTime(1999, 8, 22) },
            //    new Student { FullName = "Chris Evans", Email = "chris@example.com", DateOfBirth = new DateTime(1996, 3, 14) }
            //};
            //        dbContext.Set<Student>().AddRange(students);
            //        dbContext.SaveChanges();

            //        Console.WriteLine("Successfully inserted students with generated IDs:");
            //        foreach (var student in students)
            //        {
            //            Console.WriteLine($" - ID: {student.Id} | Name: {student.FullName}");
            //        }
            #endregion


            #region enrollstudents
            List<Student> Students = dbContext.Set<Student>().ToList();
            List<Course> Courses = dbContext.Set<Course>().ToList();
            int targetStudentId = 1;
            int targetCourseId = 1;

            Student? student = Students.FirstOrDefault(s => s.Id == targetStudentId);
            if (student == null)
            {
                Console.WriteLine($"[ENROLL REFUSED] Student ID {targetStudentId} does not exist in database.");
            }
            else
            {
                Course? course = Courses.FirstOrDefault(c => c.Id == targetCourseId);
                if (course == null)
                {
                    Console.WriteLine($"[ENROLL REFUSED] Course ID {targetCourseId} does not exist in database.");
                }
                else if (!course.IsPublished)
                {
                    Console.WriteLine($"[ENROLL REFUSED] Course '{course.Title}' (ID {course.Id}) is not published.");
                }
                else
                {
                    bool alreadyEnrolled = dbContext.Set<Enrollment>()
                        .Any(e => e.StudentId == targetStudentId && e.CourseId == targetCourseId);

                    if (alreadyEnrolled)
                    {
                        Console.WriteLine($"[ENROLL REFUSED] Student '{student.FullName}' is already enrolled in course '{course.Title}'.");
                    }
                    else
                    {
                        var enrollment = new Enrollment
                        {
                            StudentId = student.Id,
                            CourseId = course.Id,
                            EnrollmentDate = DateTime.Now,
                            ProgressPercentage = 0m,
                            Status = EnrollmentStatus.Active
                        };

                        dbContext.Set<Enrollment>().Add(enrollment);
                        dbContext.SaveChanges();

                        Console.WriteLine($"[ENROLL SUCCESS] Student '{student.FullName}' successfully enrolled in '{course.Title}'.");
                    }
                }
            }
            #endregion

            #region Read
            int searchCourseId = 1;
            Course? courseByFind = dbContext.Set<Course>().Find(searchCourseId);

            if (courseByFind == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                Course? courseByTitle = dbContext.Set<Course>()
                    .FirstOrDefault(c => c.Title == courseByFind.Title);

                if (courseByTitle == null)
                {
                    Console.WriteLine("not found");
                }
                else
                {
                    Console.WriteLine($"Found Course: ID={courseByTitle.Id}, Title='{courseByTitle.Title}'");
                }
            }

            decimal minPrice = 30.00m;
            decimal maxPrice = 80.00m;

            var filteredCourses = dbContext.Set<Course>()
                .Where(c => c.Price >= minPrice && c.Price <= maxPrice)
                .OrderByDescending(c => c.Price)
                .Select(c => new { c.Title, c.Level, c.Price })
                .ToList();

            if (!filteredCourses.Any())
            {
                Console.WriteLine("not found");
            }
            else
            {
                foreach (var c in filteredCourses)
                {
                    Console.WriteLine($"Title: {c.Title} | Level: {c.Level} | Price: ${c.Price}");
                }
            }

            int targetParentCategoryId = 2;

            var subCategories = dbContext.Set<Category>()
                .Where(c => c.ParentCategoryId == targetParentCategoryId)
                .ToList();

            if (!subCategories.Any())
            {
                Console.WriteLine("not found");
            }
            else
            {
                foreach (var sub in subCategories)
                {
                    Console.WriteLine($"Sub-Category ID: {sub.Id}, Name: {sub.Name}");
                }
            }

            var topLevelCategories = dbContext.Set<Category>()
                .Where(c => c.ParentCategoryId == null)
                .ToList();

            if (!topLevelCategories.Any())
            {
                Console.WriteLine("not found");
            }
            else
            {
                foreach (var top in topLevelCategories)
                {
                    Console.WriteLine($"Top-Level Category ID: {top.Id}, Name: {top.Name}");
                }
            }

            int rosterCourseId = 1;

            List<int> enrolledStudentIds = dbContext.Set<Enrollment>()
                .Where(e => e.CourseId == rosterCourseId)
                .Select(e => e.StudentId)
                .ToList();

            Console.WriteLine($"Enrolled Students Count: {enrolledStudentIds.Count}");

            if (enrolledStudentIds.Any())
            {
                List<string> studentNames = dbContext.Set<Student>()
                    .Where(s => enrolledStudentIds.Contains(s.Id))
                    .Select(s => s.FullName)
                    .ToList();

                foreach (var name in studentNames)
                {
                    Console.WriteLine($"Student Name: {name}");
                }
            }
            #endregion


            #region Update
            int targetcourseId = 1;
            decimal newPrice = 59.99m;

            Course? courseToUpdate = dbContext.Set<Course>().Find(targetcourseId);
            if (courseToUpdate == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                courseToUpdate.Price = newPrice;
                dbContext.SaveChanges();
                Console.WriteLine($"Updated Course ID {courseToUpdate.Id} price to ${courseToUpdate.Price}");
            }

            int studentIdKey = 1;
            int courseIdKey = 1;
            decimal newProgress = 100m;

            if (newProgress < 0m || newProgress > 100m)
            {
                Console.WriteLine("Invalid progress value. Progress must be between 0 and 100.");
            }
            else
            {
                Enrollment? enrollmentToUpdate = dbContext.Set<Enrollment>()
                    .Find(studentIdKey, courseIdKey);

                if (enrollmentToUpdate == null)
                {
                    Console.WriteLine("not found");
                }
                else
                {
                    enrollmentToUpdate.ProgressPercentage = newProgress;
                    if (newProgress == 100m)
                    {
                        enrollmentToUpdate.Status = EnrollmentStatus.Completed;
                    }

                    dbContext.SaveChanges();
                    Console.WriteLine($"Updated enrollment progress to {enrollmentToUpdate.ProgressPercentage}%. Status: {enrollmentToUpdate.Status}");
                }
            }

            int publishCourseId = 2;

            Course? courseToPublish = dbContext.Set<Course>().Find(publishCourseId);
            if (courseToPublish == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                courseToPublish.IsPublished = true;
                courseToPublish.PublishedDate = DateTime.Now;
                dbContext.SaveChanges();
                Console.WriteLine($"Course ID {courseToPublish.Id} published on {courseToPublish.PublishedDate}");
            }
            #endregion
            #region Delete
            int unenrollStudentId = 1;
            int unenrollCourseId = 1;

            Enrollment? enrollmentToDelete = dbContext.Set<Enrollment>()
                .Find(unenrollStudentId, unenrollCourseId);

            if (enrollmentToDelete == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                dbContext.Set<Enrollment>().Remove(enrollmentToDelete);
                dbContext.SaveChanges();
                Console.WriteLine($"Unenrolled Student ID {unenrollStudentId} from Course ID {unenrollCourseId}");
            }

            int unsafeCategoryId = 1;
            Category? unsafeCategory = dbContext.Set<Category>().Find(unsafeCategoryId);

            if (unsafeCategory == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                try
                {
                    dbContext.Set<Category>().Remove(unsafeCategory);
                    dbContext.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine($"DbUpdateException caught: {ex.InnerException?.Message ?? ex.Message}");
                    dbContext.Entry(unsafeCategory).State = EntityState.Unchanged;
                }
            }

            int safeCategoryId = 1;
            Category? safeCategory = dbContext.Set<Category>().Find(safeCategoryId);

            if (safeCategory == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                bool hasSubCategories = dbContext.Set<Category>()
                    .Any(c => c.ParentCategoryId == safeCategoryId);

                if (hasSubCategories)
                {
                    Console.WriteLine($"Cannot delete Category ID {safeCategoryId}: it contains sub-categories.");
                }
                else
                {
                    dbContext.Set<Category>().Remove(safeCategory);
                    dbContext.SaveChanges();
                    Console.WriteLine($"Successfully deleted Category ID {safeCategoryId}");
                }
            }

            int deleteCourseId = 1;
            Course? courseToDelete = dbContext.Set<Course>().Find(deleteCourseId);

            if (courseToDelete == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                int enrollmentsBefore = dbContext.Set<Enrollment>()
                    .Count(e => e.CourseId == deleteCourseId);

                Console.WriteLine($"Enrollments count before course deletion: {enrollmentsBefore}");

                dbContext.Set<Course>().Remove(courseToDelete);
                dbContext.SaveChanges();

                /*
                 * Enrolled records were deleted automatically because Cascade Delete 
                 * is enabled on the foreign key relationship between Course and Enrollment 
                 * (DeleteBehavior.Cascade configured in Fluent API).
                 */

                int enrollmentsAfter = dbContext.Set<Enrollment>()
                    .Count(e => e.CourseId == deleteCourseId);

                Console.WriteLine($"Enrollments count after course deletion: {enrollmentsAfter}");
            }

            #endregion


            #region Bulkoperation
            CourseLevel targetLevel = CourseLevel.Beginner;

            int priceRowsAffected = dbContext.Set<Course>()
                .Where(c => c.IsPublished && c.Level == targetLevel)
                .ExecuteUpdate(setters => setters.SetProperty(
                    c => c.Price,
                    c => c.Price * 1.10m
                ));

            Console.WriteLine($"Bulk price raise affected {priceRowsAffected} row(s).");

            int deleteRowsAffected = dbContext.Set<Enrollment>()
                .Where(e => e.Status == EnrollmentStatus.Dropped)
                .ExecuteDelete();

            Console.WriteLine($"Bulk delete affected {deleteRowsAffected} row(s).");
            #endregion
        }

        }
    }

