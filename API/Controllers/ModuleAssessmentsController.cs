using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleAssessmentsController : ControllerBase
    {
        private ModuleAssessmentsRepo _moduleAssessmentsRepo = new ModuleAssessmentsRepo();


        [HttpGet("GetAllModulesAssessment")]
        public IActionResult GetAllProgrammeModules()
        {
            var output = _moduleAssessmentsRepo.GetAllModuleAssessments();
            if (output == null)
            {
                return NotFound("No record found");
            }
            return Ok(output);
        }

        [HttpGet("GetModulesAssessmentByModAssessmentId")]
        public IActionResult GetModulesAssessmentByModAssessmentId(string ModAssessmentId)
        {
            var output = _moduleAssessmentsRepo.GetModuleAssessmentByModuleAssessmentId(ModAssessmentId);
            if (output == null)
            {
                return NotFound($"No record found for {ModAssessmentId}");
            }
            return Ok(output);
        }

        [HttpGet("GetModuleAssessmentByDegreeProgrammeId")]
        public IActionResult GetModuleAssessementByDegreeProgrammeId(string DegProgId)
        {
            var output = _moduleAssessmentsRepo.GetProgrammeModuleByDegreeProgrammeId(DegProgId);
            if (output == null)
            {
                return NotFound($"No record found for {DegProgId}");
            }
            return Ok(output);
        }
    }
}
