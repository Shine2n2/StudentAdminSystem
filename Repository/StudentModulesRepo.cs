using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class StudentModulesRepo
    {
        StudentModulesDB _studentModulesDB = new StudentModulesDB();
        ProgrammeModulesRepo _programmeModulesRepo = new ProgrammeModulesRepo();   
        public bool CreateStudentModule(StudentModules studentModules)
        {
            _studentModulesDB.StudentModuleData().Add(studentModules);                     
            return true;
        }

        public List<StudentModules> GetAllStudentModule()
        {
            return _studentModulesDB.StudentModuleData();
        }

        public List<StudentModules> GetStudentModuleByStudentId(string studentId)
        {
            if (_studentModulesDB.StudentModuleData().Any(x => x.StudentId == studentId))
            {
                var result = from x in _studentModulesDB.StudentModuleData() where x.StudentId == studentId select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {studentId}");
        }

        

        public List<StudentModules> GetStudentModuleByProgrammeModuleId(string Id)
        {
            if (_studentModulesDB.StudentModuleData().Any(x => x.ProgrammeModuleId == Id))
            {
                var result = from x in _studentModulesDB.StudentModuleData() where x.ProgrammeModuleId == Id select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {Id}");
        }
    }
}
