using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DegreeProgrammeController : ControllerBase
    {
        DegreeProgrammeRepo _degreeProgrammeRepo = new DegreeProgrammeRepo();

        [HttpGet("GetAllProgrammeModules")]
        public IActionResult GetAllDegreeProgramme()
        {
            var output = _degreeProgrammeRepo.GetAllDegreeProgramme();
            if (output == null)
            {
                return NotFound("No record found");
            }
            return Ok(output);
        }
                

        [HttpGet("GetDegreeProgrammeByDegreeProgrammeId")]
        public IActionResult GetProgrammeModulesByDegreeProgrammeId(string DegProgId)
        {
            var output = _degreeProgrammeRepo.GetDegreeProgrammeByDegreeProgrammeId(DegProgId);
            if (output == null)
            {
                return NotFound($"No record found for {DegProgId}");
            }
            return Ok(output);
        }
    }
}
