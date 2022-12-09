using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ModuleAssessmentsRepo
    {

        ModuleAssessmentsDB _modulesAssessmentDB = new ModuleAssessmentsDB();

        public List<ModuleAssessments> GetAllModuleAssessments()
        {
            return _modulesAssessmentDB.ModuleAssessmentData();
        }
        public List<ModuleAssessments> GetModuleAssessmentByModuleAssessmentId(string modAssessmentId)
        {
            if (_modulesAssessmentDB.ModuleAssessmentData().Any(x => x.ModuleAssessmentsId == modAssessmentId))
            {
                var result = from x in _modulesAssessmentDB.ModuleAssessmentData() where x.ModuleAssessmentsId == modAssessmentId select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {modAssessmentId}");

        }
        public List<ModuleAssessments> GetProgrammeModuleByDegreeProgrammeId(string degreeProgrammeid)
        {
            if (_modulesAssessmentDB.ModuleAssessmentData().Any(x => x.ProgrammeModuleId == degreeProgrammeid))
            {
                var result = from x in _modulesAssessmentDB.ModuleAssessmentData() where x.ProgrammeModuleId == degreeProgrammeid select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {degreeProgrammeid}");
        }

        public List<ModuleAssessments> GetProgrammeModuleByProgrammeModuleId(string programmeModuleid)
        {
            if (_modulesAssessmentDB.ModuleAssessmentData().Any(x => x.ProgrammeModuleId == programmeModuleid))
            {
                var result = from x in _modulesAssessmentDB.ModuleAssessmentData() where x.ProgrammeModuleId == programmeModuleid select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {programmeModuleid}");
        }
    }
}
