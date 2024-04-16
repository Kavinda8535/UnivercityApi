using UniversityRegistrationCore.Models;

namespace UniversityRegistrationCore.Repositories.Interfaces
{
    public interface IProfessorRepository : IRepository<Professor>
    {
        Task<IEnumerable<Professor>> GetProfessorsByDepartmentIdAsync(int departmentId);

        Task<IEnumerable<Professor>> GetProfessorsBySubjectIdAsync(int subjectId);
    }
}
