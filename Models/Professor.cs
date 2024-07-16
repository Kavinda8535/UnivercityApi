using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityRegistrationCore.Models
{
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfessorId { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        // Navigation property
        public Subject? Subjects { get; set; }
    }
}
