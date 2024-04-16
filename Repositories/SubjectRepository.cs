using UniversityRegistrationCore.Data;
using UniversityRegistrationCore.Models;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Repositories
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(UniversityDbContext context) : base(context)
        {
        }

        // Any additional methods implemantation specific to the Subject entity here

        public Task<IEnumerable<Subject>> GetSubjectsByDepartmentIdAsync(int departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Subject>> GetSubjectsByProfessorIdAsync(int departmentId)
        {
            throw new NotImplementedException();
        }
    }
}
