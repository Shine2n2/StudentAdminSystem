using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class StudentAssessmentsDB
    {
        public List<StudentAssessments> StudentAssessmentData()
        {
            List<StudentAssessments> studentAssessments = new List<StudentAssessments>
            {
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 70, IsUndefined = false, StudentId = "2021302634", ProgrammeModuleId = "MOD134543"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 50, IsUndefined = false, StudentId = "2021302634", ProgrammeModuleId = "MOD234544"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 40, IsUndefined = false, StudentId = "2021302634", ProgrammeModuleId = "MOD334545"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 30, IsUndefined = false, StudentId = "2021302634", ProgrammeModuleId = "MOD434345"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 80, IsUndefined = false, StudentId = "2021302634", ProgrammeModuleId = "MOD534245"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 90, IsUndefined = false, StudentId = "2021302634", ProgrammeModuleId = "MOD634546"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 75, IsUndefined = false, StudentId = "2021302635", ProgrammeModuleId = "MOD122545"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 54, IsUndefined = false, StudentId = "2021302635", ProgrammeModuleId = "MOD322546"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 40, IsUndefined = false, StudentId = "2021302635", ProgrammeModuleId = "MOD522547"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 30, IsUndefined = false, StudentId = "2021302635", ProgrammeModuleId = "MOD222537"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 60, IsUndefined = false, StudentId = "2021302635", ProgrammeModuleId = "MOD422321"},
                new StudentAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", StudentAssessmentScore = 20, IsUndefined = false, StudentId = "2021302635", ProgrammeModuleId = "MOD722311"},
            };
            return studentAssessments;
        }
    }
}
