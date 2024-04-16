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
            CreateMap<Department, DepartmentDTO>();
            // DTO to Entity
            CreateMap<DepartmentDTO, Department>();

            // Add additional mappings as needed
        }
    }
}
