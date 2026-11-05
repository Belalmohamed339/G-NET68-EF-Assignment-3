using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_3.models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public DateTime JoinedDate { get; set; }

        // Navigation property: One instructor can publish many courses
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
