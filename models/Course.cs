using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_3.models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public CourseLevel Level { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }

        // Foreign Keys & Navigation Properties
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        // Navigation property: A course can have many enrollments
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
