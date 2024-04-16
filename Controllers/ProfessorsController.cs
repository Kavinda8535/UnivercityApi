using Microsoft.AspNetCore.Mvc;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        
        private readonly IUnitOfWork _unitOfWork;

        public ProfessorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Subjects
        [HttpGet]
        public async Task<IActionResult> GetSubjects()
        {
            var professors = await _unitOfWork.Professors.GetAllAsync();
            return Ok(professors);
        }
    }
}
