using UniversityRegistrationCore.Data;
using UniversityRegistrationCore.Models;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Repositories
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(UniversityDbContext context) : base(context)
        {
        }

        // Any additional methods implemantation specific to the Professor entity here

        public Task<IEnumerable<Professor>> GetProfessorsByDepartmentIdAsync(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Professor>> GetProfessorsBySubjectIdAsync(int subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
