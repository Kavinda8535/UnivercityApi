using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrationCore.DTOs;
using UniversityRegistrationCore.Models;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProfessorsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;;
            _mapper = mapper;
        }

        // GET: api/Subjects
        [HttpGet]
        public async Task<IActionResult> GetProfessors()
        {
            var professors = await _unitOfWork.Professors.GetAllAsync();
            var professorDTOs = _mapper.Map<IEnumerable<ProfessorDTO>>(professors);
            return Ok(professorDTOs);
        }

        // POST: api/Professors
        [HttpPost]
        public async Task<IActionResult> CreateProfessor([FromBody] ProfessorDTO professorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var professor = _mapper.Map<Professor>(professorDTO);
            await _unitOfWork.Professors.AddAsync(professor);
            await _unitOfWork.CompleteAsync();

            var createdProfessorDTO = _mapper.Map<ProfessorDTO>(professor);

            return CreatedAtAction(nameof(GetProfessor), new { id = createdProfessorDTO.ProfessorId }, createdProfessorDTO);
        }

        // GET: api/Professors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessorDTO>> GetProfessor(int id)
        {
            var professor = await _unitOfWork.Professors.GetByIdAsync(id);

            if (professor == null)
            {
                return NotFound();
            }

            var professortDTO = _mapper.Map<ProfessorDTO>(professor);

            return Ok(professortDTO);
        }
    }
}
