using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityRegistrationCore.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        // Navigation property
        public IList<Subject>? Subjects { get; set; }

        //public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
