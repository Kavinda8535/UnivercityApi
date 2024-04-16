namespace UniversityRegistrationCore.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Departments { get; }
        ISubjectRepository Subjects { get; }
        IProfessorRepository Professors { get; }
        Task<int> CompleteAsync();
    }
}
