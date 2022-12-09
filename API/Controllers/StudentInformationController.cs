using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using Utilities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentInformationController : ControllerBase
    {
        private StudentInformationRepo _studentsInformationRepo = new StudentInformationRepo();
        Handlers _handler = new Handlers();
      

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudentInformation()
        {
            var output = _studentsInformationRepo.GetAllStudent();
            if (output == null)
            {
                return NotFound("No record found");
            }
            return Ok(output);
        }

        [HttpGet("GetStudentbystudentId")]
        public IActionResult GetStudentInformationByStudentId(string studentId)
        {
            var output = _studentsInformationRepo.GetStudentByStudentId(studentId);
            if (output == null)
            {
                return NotFound($"No record found for {studentId}");
            }
            return Ok(output);
        }

        [HttpGet("GetStudentByProgrammeId")]
        public IActionResult GetStudentDetailsByProgrammeId(string DegreeProgrammeId)
        {
            var output = _studentsInformationRepo.GetStudentByDegreeProgrammeId(DegreeProgrammeId);
            if (output == null)
            {
                return NotFound($"No record found for {DegreeProgrammeId}");
            }
            return Ok(output);
        }

        [HttpGet("GetStudentByCohort")]
        public IActionResult GetStudentInformationByCohort(string yearOfStudy)
        {
            var output = _studentsInformationRepo.GetStudentByYearOfStudy(yearOfStudy);
            if (output == null)
            {
                return NotFound($"No record found for cohort {yearOfStudy}");
            }
            return Ok(output);
        }

        [HttpGet("GetStudentByDuration")]
        public IActionResult GetStudentInformationByDuration(int duration)
        {
            var output = _studentsInformationRepo.GetStudentByDuration(duration);
            if (output == null)
            {
                return NotFound($"No record found for duration {duration}");
            }
            return Ok(output);
        }

        [HttpDelete("DeleteStudentRecordById")]
        public IActionResult DeleteStudentRecordByStudentId(string studentId)
        {
            var output = _studentsInformationRepo.DeleteStudentByStudentId(studentId);
            if (!output)
            {
                return NotFound($"No recor found for {studentId}");
            }
            return Ok($"Successfully deleted {studentId}");
        }

        [HttpPost("CreateNewStudentRecord")]
        public IActionResult CreateNewStudentRecord(StudentInformation studentInfo)
        {
            var output = _handler.CreateNewStudentHandler(studentInfo);          
            if (output == null)
            {
                return BadRequest($"Student Creation was not successful");
            }
            return Ok(output);
        }

    }
}
