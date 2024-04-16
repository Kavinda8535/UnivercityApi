namespace UniversityRegistrationCore.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Name { get; set; }
        // Navigation property
        public List<Subject> Subjects { get; set; }
    }
}
