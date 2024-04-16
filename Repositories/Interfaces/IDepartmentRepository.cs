using UniversityRegistrationCore.Models;

namespace UniversityRegistrationCore.Repositories.Interfaces
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        // Any additional operations specific to the Department entity

        Task<IEnumerable<Department>> GetDepartmentsByProfessorIdAsync(int professorId);

        Task<IEnumerable<Department>> GetDepartmentsBySubjectIdAsync(int subjectId);
    }
}
