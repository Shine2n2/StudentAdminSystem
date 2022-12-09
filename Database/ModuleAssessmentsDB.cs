using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class ModuleAssessmentsDB
    {
        public List<ModuleAssessments> ModuleAssessmentData()
        {
            List<ModuleAssessments> moduleAssessment = new List<ModuleAssessments>
            {
                new ModuleAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", ProgrammeModuleId = "MOD1"},
                new ModuleAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", ProgrammeModuleId = "MOD2"},
                new ModuleAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", ProgrammeModuleId = "MOD3"},
                new ModuleAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", ProgrammeModuleId = "MOD4"},
                new ModuleAssessments{ModuleAssessmentsId = "ASCS00211", ModuleAssessmentsTitle = "Final Assessment", ProgrammeModuleId = "MOD5"},
               
            };
            return moduleAssessment;
        }
    }
}
