using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAssessmentsController : ControllerBase
    {
        private StudentAssessmentsRepo _studentAssessmentRepo = new StudentAssessmentsRepo();


        [HttpGet("GetAllStudentAssessmenet")]
        public IActionResult GetAllStudentAssessmenet()
        {
            var result = _studentAssessmentRepo.GetAllStudentAssessments();
            if (result == null)
            {
                return NotFound("No assessment found");
            }
            return Ok(result);
        }

        [HttpGet("GetStudentAssessmentByStudentId")]
        public IActionResult GetStudentAssessmentByStudentId(string studentId)
        {
            var result = _studentAssessmentRepo.GetStudentAssessmentByStudentId(studentId);
            if (result == null)
            {
                return NotFound($"No assessment found for {studentId}");
            }
            return Ok(result);
        }               
    }
}
