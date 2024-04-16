using UniversityRegistrationCore.Data;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UniversityDbContext _context;

        public IDepartmentRepository Departments { get; private set; }
        public ISubjectRepository Subjects { get; private set; }
        public IProfessorRepository Professors { get; private set; }

        public UnitOfWork(UniversityDbContext context)
        {
            _context = context;
            Departments = new DepartmentRepository(_context);
            Subjects = new SubjectRepository(_context);
            Professors = new ProfessorRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
