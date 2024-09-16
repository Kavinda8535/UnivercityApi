using UniversityRegistrationCore.Models;

namespace UniversityRegistrationCore.Data
{
    public class DbInitializer
    {
        //For seeding the database with initial data

        public static void Initialize(UniversityDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Look for any departments
            if (context.Departments.Any())
            {
                return;   // DB has been seeded
            }

            //TODO - Professors has no department and no subjects. Fix it.
            //Make a custome middleware to Exception Error handling...
            // Check all data created or not. If partiallly  update data make sure to updte all.

            // Seed Departments
            var departments = new Department[]
            {
            new Department { Name = "Computer Science" },
            new Department { Name = "Mathematics" },
            new Department { Name = "Physics" }
            };

            foreach (var d in departments)
            {
                context.Departments.Add(d);
            }

            context.SaveChanges();

            // Seed Subjects
            var subjects = new Subject[]
            {
            new Subject { Name = "Algorithms", DepartmentId = departments[0].DepartmentId },
            new Subject { Name = "Data Structures", DepartmentId = departments[0].DepartmentId },
            new Subject { Name = "Calculus", DepartmentId = departments[1].DepartmentId },
            new Subject { Name = "Linear Algebra", DepartmentId = departments[1].DepartmentId },
            new Subject { Name = "Quantum Mechanics", DepartmentId = departments[2].DepartmentId },
            new Subject { Name = "Electromagnetism", DepartmentId = departments[2].DepartmentId }
            };

            foreach (var s in subjects)
            {
                context.Subjects.Add(s);
            }

            context.SaveChanges();

            // Seed Professors
            var professors = new Professor[]
            {
            new Professor { Name = "Dr. Smith", SubjectId = subjects[0].SubjectId },
            new Professor { Name = "Dr. Johnson", SubjectId = subjects[1].SubjectId },
            new Professor { Name = "Dr. Williams", SubjectId = subjects[2].SubjectId },
            new Professor { Name = "Dr. Brown", SubjectId = subjects[3].SubjectId },
            new Professor { Name = "Dr. Jones", SubjectId = subjects[4].SubjectId },
            new Professor { Name = "Dr. Garcia", SubjectId = subjects[5].SubjectId }
            };

            foreach (var p in professors)
            {
                context.Professors.Add(p);
            }

            context.SaveChanges();
        }
    }
}
