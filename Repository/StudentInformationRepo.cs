using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class StudentInformationRepo
    {
        StudentInformationDB _studentInfoDb = new StudentInformationDB();
        public StudentInformation CreateNewStudent(StudentInformation studentDetail)
        {
            _studentInfoDb.StudentInformationsData().Add(studentDetail);
            return studentDetail;
        }

        public List<StudentInformation> UpdateStudent()
        {
            List<StudentInformation> students = new List<StudentInformation>();
            return students;
        }
        

        public List<StudentInformation> GetAllStudent()
        {
            return _studentInfoDb.StudentInformationsData();
        }

        public List<StudentInformation> GetStudentByStudentId(string studentId)
        {
            if (_studentInfoDb.StudentInformationsData().Any(x => x.StudentId == studentId))
            {
                var result = from x in _studentInfoDb.StudentInformationsData() where x.StudentId == studentId select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {studentId}");
        }

        public List<StudentInformation> GetStudentByYearOfStudy(string yearOfStudy)
        {
            if (_studentInfoDb.StudentInformationsData().Any(x => x.YearOfStudy == yearOfStudy))
            {
                var result = from x in _studentInfoDb.StudentInformationsData() where x.YearOfStudy == yearOfStudy select x;
                return result.ToList();
            }
            throw new Exception($"No Existing Student record for this cohort {yearOfStudy}");
        }

        public List<StudentInformation> GetStudentByDuration(int duration)
        {
            if (_studentInfoDb.StudentInformationsData().Any(x => x.DegreeProgrammeDuration == duration))
            {
                var result = from x in _studentInfoDb.StudentInformationsData() where x.DegreeProgrammeDuration == duration select x;
                return result.ToList();
            }
            throw new Exception($"No Existing Student record for this request");
        }

        public List<StudentInformation> GetStudentByDegreeProgrammeId(string programmeId)
        {
            if (_studentInfoDb.StudentInformationsData().Any(x => x.DegreeProgrammeId == programmeId))
            {
                var result = from x in _studentInfoDb.StudentInformationsData() where x.DegreeProgrammeId == programmeId select x;
                return result.ToList();
            }
            throw new Exception($"No Existing Student record for this Programme with Id {programmeId}");
        }
        public bool DeleteStudentByStudentId(string studentId)
        {
            if (_studentInfoDb.StudentInformationsData().Any(x => x.StudentId == studentId))
            {
                var result = from x in _studentInfoDb.StudentInformationsData() where x.StudentId == studentId select x;
                var result2 = _studentInfoDb.StudentInformationsData().Remove((StudentInformation)result);
                if (result2)
                {
                    return true;
                }
                throw new Exception($"Deletion not successful for Id {studentId}");
            }
            throw new Exception($"No record found for Id {studentId}");
        }
    }
}
