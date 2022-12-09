using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class StudentAssessmentsRepo
    {
        StudentAssessmentsDB _studentAssessmentDB = new StudentAssessmentsDB();
        public List<StudentAssessments> GetAllStudentAssessments()
        {
            return _studentAssessmentDB.StudentAssessmentData();
        }
        public List<StudentAssessments> GetStudentAssessmentByStudentId(string studentId)
        {
            if (_studentAssessmentDB.StudentAssessmentData().Any(x => x.StudentId == studentId))
            {
                var result = from x in _studentAssessmentDB.StudentAssessmentData() where x.StudentId == studentId select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {studentId}");
        }        

        public StudentAssessments CreateStudentAssessment(StudentAssessments studentAssessment)
        {
            _studentAssessmentDB.StudentAssessmentData().Add(studentAssessment);
            return studentAssessment;
        }
    }
}
