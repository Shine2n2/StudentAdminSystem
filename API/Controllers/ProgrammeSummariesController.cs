using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammeSummariesController : ControllerBase
    {
        private ProgrammeSummaryRepo _programmeSummaryRepo = new ProgrammeSummaryRepo();


        [HttpGet("GetAllProgrammeSummary")]
        public IActionResult GetAllStudentAssessmenet()
        {
            var result = _programmeSummaryRepo.GetAllProgrammeSummary();
            if (result == null)
            {
                return NotFound("No record found");
            }
            return Ok(result);
        }

        [HttpGet("GetProgrammeSummaryByStudentId")]
        public IActionResult GetStudentAssessmentByStudentId(string studentId)
        {
            var result = _programmeSummaryRepo.GetProgrammeSummaryByStudentId(studentId);
            if (result == null)
            {
                return NotFound($"No record found for {studentId}");
            }
            return Ok(result);
        }
    }
}
