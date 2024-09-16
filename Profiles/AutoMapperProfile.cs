using UniversityRegistrationCore.DTOs;
using UniversityRegistrationCore.Models;
using AutoMapper;

namespace UniversityRegistrationCore.Profiles
{
    public class AutoMapperProfile : Profile
    {
        // AutoMapper, for mapping entities to DTOs
        public AutoMapperProfile()
        {
            // Entity to DTO
            CreateMap<Department, DepartmentDTO>().ReverseMap();
            // DTO to Entity
            //CreateMap<DepartmentDTO, Department>(); We dont need this line of code becouse with the ReverseMap() method will cover this code. Mapping DTO to Entity.

            // Add additional mappings as needed
            CreateMap<Subject, SubjectDTO>().ReverseMap();
            CreateMap<Professor, ProfessorDTO>().ReverseMap();
            CreateMap<Student, StudentDTO>().ReverseMap();
        }
    }
}
