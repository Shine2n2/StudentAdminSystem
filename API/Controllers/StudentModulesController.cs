using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentModulesController : ControllerBase
    {
        private StudentModulesRepo _studentModuleRepo = new StudentModulesRepo();


        [HttpGet("GetAllStudentModule")]
        public IActionResult GetAllStudentModuleDetail()
        {
            var output = _studentModuleRepo.GetAllStudentModule();
            if (output == null)
            {
                return NotFound("No module found");
            }
            return Ok(output);
        }

        [HttpGet("GetStudentModuleByStudentId")]
        public IActionResult GetStudentModuleByStudentId(string studentId)
        {
            var result = _studentModuleRepo.GetStudentModuleByStudentId(studentId);
            if (result == null)
            {
                return NotFound($"No module detail found for {studentId}");
            }
            return Ok(result);
        }

        [HttpGet("GetStudentModuleByProgrammeModId")]
        public IActionResult GetStudentModuleByProgrammeId(string programmeModId)
        {            
                var result = _studentModuleRepo.GetStudentModuleByProgrammeModuleId(programmeModId);
                if (result == null)
                {
                    return NotFound($"No module found for {programmeModId}");
                }
                return Ok(result);         
        }      

    }
}

