using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_3.models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        // Self-referencing relationship for tree structure
        public int? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; } = new List<Category>();

        // Navigation property: A category contains many courses
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
