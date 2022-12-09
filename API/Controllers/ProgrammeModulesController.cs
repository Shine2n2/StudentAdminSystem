using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammeModulesController : ControllerBase
    {
        private ProgrammeModulesRepo _programmeModuleRepo = new ProgrammeModulesRepo();


        [HttpGet("GetAllProgrammeModules")]
        public IActionResult GetAllProgrammeModules()
        {
            var output = _programmeModuleRepo.GetAllProgrammeModules();
            if (output == null)
            {
                return NotFound("No record found");
            }
            return Ok(output);
        }

        [HttpGet("GetProgrammeModuleByProgrammeModId")]
        public IActionResult GetProgrammeModuleByProgrammeModId(string ProgModId)
        {
            var output = _programmeModuleRepo.GetProgrammeModuleByProgModId(ProgModId);
            if (output == null)
            {
                return NotFound($"No record found for {ProgModId}");
            }
            return Ok(output);
        }

        [HttpGet("GetProgrammeModuleByDegreeProgrammeId")]
        public IActionResult GetProgrammeModuleByDegreeProgrammeId(string degProgModId)
        {
            var output = _programmeModuleRepo.GetProgrammeModuleByDegreeProgrammeId(degProgModId);
            if (output == null)
            {
                return NotFound($"No record found for {degProgModId}");
            }
            return Ok(output);
        }
    }
}
