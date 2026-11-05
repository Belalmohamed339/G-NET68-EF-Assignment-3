using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_3.models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        // Navigation property: A student can have many enrollments
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    }
}
