using UniversityRegistrationCore.Models;

namespace UniversityRegistrationCore.Repositories.Interfaces
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        // Any additional operations specific to the Subject entity
        Task<IEnumerable<Subject>> GetSubjectsByDepartmentIdAsync(int departmentId);

        Task<IEnumerable<Subject>> GetSubjectsByProfessorIdAsync(int departmentId);
    }
}

