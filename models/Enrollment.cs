using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_3.models
{
    internal class Enrollment
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public decimal ProgressPercentage { get; set; }
        public EnrollmentStatus Status { get; set; }
        public decimal? FinalGrade { get; set; }

        // Foreign Keys & Navigation Properties
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
