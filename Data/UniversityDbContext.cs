using Microsoft.EntityFrameworkCore;
using UniversityRegistrationCore.Models;

namespace UniversityRegistrationCore.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
       : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Professor> Professors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Fluent API configurations can go here
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(d => d.DepartmentId);
                entity.Property(d => d.DepartmentId).ValueGeneratedOnAdd();
                // Additional configurations
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(d => d.SubjectId);
                entity.Property(d => d.SubjectId).ValueGeneratedOnAdd();
                // Additional configurations
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasKey(d => d.ProfessorId);
                entity.Property(d => d.ProfessorId).ValueGeneratedOnAdd();
                // Additional configurations
            });


        }
    }
}
