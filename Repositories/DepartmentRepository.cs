using UniversityRegistrationCore.Data;
using UniversityRegistrationCore.Models;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(UniversityDbContext context) : base(context)
        {
        }

        // Any additional methods implemantation specific to the Department entity here

        public Task<IEnumerable<Department>> GetDepartmentsByProfessorIdAsync(int professorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetDepartmentsBySubjectIdAsync(int subjectId)
        {
            throw new NotImplementedException();
        }

        
    }
}
