using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityRegistrationCore.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        // Navigation property
        public Department Department { get; set; }
        public int ProfessorId { get; set; }
        // Navigation property
        public Professor Professor { get; set; }
    }
}
