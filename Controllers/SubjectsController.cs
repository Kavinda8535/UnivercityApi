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
    public class SubjectsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SubjectsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/Subjects
        [HttpGet]
        public async Task<IActionResult> GetSubjects()
        {
            var subjects = await _unitOfWork.Subjects.GetAllAsync();
            var subjectDTOs = _mapper.Map<IEnumerable<SubjectDTO>>(subjects);
            return Ok(subjectDTOs);
        }

        // POST: api/Subjects
        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] SubjectDTO subjectDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subject = _mapper.Map<Subject>(subjectDTO);
            await _unitOfWork.Subjects.AddAsync(subject);
            await _unitOfWork.CompleteAsync();

            var createdSubjectDTO = _mapper.Map<SubjectDTO>(subject);

            return CreatedAtAction(nameof(GetSubject), new { id = createdSubjectDTO.SubjectId }, createdSubjectDTO);
        }

        // GET: api/Subjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubjectDTO>> GetSubject(int id)
        {
            var subject = await _unitOfWork.Subjects.GetByIdAsync(id);

            if (subject == null)
            {
                return NotFound();
            }

            var subjectDTO = _mapper.Map<SubjectDTO>(subject);

            return Ok(subjectDTO);
        }
    }
}
