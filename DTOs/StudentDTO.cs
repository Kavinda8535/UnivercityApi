namespace UniversityRegistrationCore.DTOs
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int DepartmentId { get; set; }
    }
}
