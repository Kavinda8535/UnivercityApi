using UniversityRegistrationCore.Data;
using UniversityRegistrationCore.Models;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(UniversityDbContext context) : base(context)
        {
        }
    }
}
