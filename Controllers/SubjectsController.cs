using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Subjects
        [HttpGet]
        public async Task<IActionResult> GetSubjects()
        {
            var subjects = await _unitOfWork.Subjects.GetAllAsync();
            return Ok(subjects);
        }
    }
}
