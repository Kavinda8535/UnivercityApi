using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrationCore.DTOs;
using UniversityRegistrationCore.Models;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/Departments
        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            var departments = await _unitOfWork.Departments.GetAllAsync();
            var departmentDTOs = _mapper.Map<IEnumerable<DepartmentDTO>>(departments);
            return Ok(departmentDTOs);
        }

        // POST: api/Departments
        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] DepartmentDTO departmentDTO)
        {
            var department = _mapper.Map<Department>(departmentDTO);
            await _unitOfWork.Departments.AddAsync(department);
            await _unitOfWork.CompleteAsync();

            var createdDepartmentDTO = _mapper.Map<DepartmentDTO>(department);

            return CreatedAtAction(nameof(GetDepartment), new { id = createdDepartmentDTO.DepartmentId }, createdDepartmentDTO);
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentDTO>> GetDepartment(int id)
        {
            var department = await _unitOfWork.Departments.GetByIdAsync(id);

            if (department == null)
            {
                return NotFound();
            }

            var departmentDTO = _mapper.Map<DepartmentDTO>(department);

            return Ok(departmentDTO);
        }
    }
}
