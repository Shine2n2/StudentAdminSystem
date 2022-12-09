using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public class Handlers
    {
        private StudentInformationRepo _studentInformationRepo = new StudentInformationRepo();
        private IdGenerators idGenerators = new IdGenerators();
        private StudentModulesRepo _studentModules = new StudentModulesRepo();
        private StudentAssessmentsRepo _studentAssessmentsRepo = new StudentAssessmentsRepo();
        private ModuleAssessmentsRepo _moduleAssessmentsRepo = new ModuleAssessmentsRepo();
        private ProgrammeModulesRepo _programmeModulesRepo = new ProgrammeModulesRepo();
          

        public StudentInformation CreateNewStudentHandler(StudentInformation studentInfo)
        {
            try
            {
                var newStudent = new StudentInformation()
                {
                    StudentId = idGenerators.GenerateStudentId(studentInfo.YearOfStudy),
                    DegreeProgrammeId = studentInfo.DegreeProgrammeId,
                    FirstName = studentInfo.FirstName,
                    LastName = studentInfo.LastName,
                    DegreeProgrammeDuration = studentInfo.DegreeProgrammeDuration,
                    DegreeProgrammeTitle = studentInfo.DegreeProgrammeTitle,
                    YearOfStudy = studentInfo.YearOfStudy,
                    FullName = studentInfo.FirstName + " " + studentInfo.LastName
                };
                _studentInformationRepo.CreateNewStudent(newStudent);
                AssignNewStudentModuleHandler(newStudent.DegreeProgrammeId,newStudent.StudentId);
                //AssignNewModuleAssessmentHandler(newStudent.StudentId, newStudent.DegreeProgrammeId);
                return newStudent;
            }
            catch (Exception e){ throw new Exception(e.Message); }
        }


        public bool AssignNewStudentModuleHandler(string degProgrammeId, string studentId)
        {            
            var outputMod = from x in _programmeModulesRepo.GetProgrammeModuleByDegreeProgrammeId(degProgrammeId)
                            where x.DegreeProgrammeId == degProgrammeId
                            select x;

            foreach (var x in outputMod)
            {
                var newStudentModule = new StudentModules()
                {
                    StudentId = studentId,
                    IsCore = x.IsCore,
                    ProgrammeModuleId = x.ProgrammeModuleId,
                    ProgrammeModuleTitle = x.ProgrammeModuleTitle,
                    StudentModuleMark = 0
                };
                _studentModules.CreateStudentModule(newStudentModule);
            }
            return true;
        }
        


        public bool AssignNewModuleAssessmentHandler(String studentId, string DegProgId)
        {
            var outputProgMod = from x in _programmeModulesRepo.GetProgrammeModuleByDegreeProgrammeId(DegProgId)
                                where x.DegreeProgrammeId == DegProgId
                                select x;                        
            foreach (var x in outputProgMod)
            {              
                foreach (var o in _moduleAssessmentsRepo.GetProgrammeModuleByProgrammeModuleId(x.ProgrammeModuleId))
                {                    
                    var newStudentAssessment = new StudentAssessments()
                    {
                        StudentId = studentId,
                        IsUndefined = true,
                        ModuleAssessmentsId = o.ModuleAssessmentsId,
                        ModuleAssessmentsTitle = o.ModuleAssessmentsTitle,
                        ProgrammeModuleId = o.ProgrammeModuleId,
                        StudentAssessmentScore = 0
                    };
                    _studentAssessmentsRepo.CreateStudentAssessment(newStudentAssessment);
                }
            }           
            return true;
        }        
    }
}
