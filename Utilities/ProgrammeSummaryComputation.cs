using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class ProgrammeSummaryComputation
    {
        private StudentModulesRepo _studentModules = new StudentModulesRepo();
        public string ProgrammeResult(string studentId)
        {
            int sum = 0;
            int count = 0;
            var moduleOutput = _studentModules.GetStudentModuleByStudentId(studentId);
            foreach (var module in moduleOutput)
            {
                if (module.StudentId == studentId)
                {
                    count++;
                    sum = sum + module.StudentModuleMark;
                }
            }
            var result = sum / count;            
            string ProgrammeResult = string.Empty;
            if (result >= 50 && result < 69) { ProgrammeResult = "Pass"; }
            if (result >= 70) { ProgrammeResult = "Distinction"; }
            if (result < 50) { ProgrammeResult = "Fail"; }
            return ProgrammeResult;
        }

        public string ModuleResult(int score)
        {
            int ModuleMark = score;
            string ModuleResult = "";
            if (ModuleMark >= 50) {ModuleResult = "Pass";}
            if (ModuleMark >= 45 && ModuleMark < 50) {ModuleResult = "PassCompensation";}
            if (ModuleMark < 45){ModuleResult = "Fail";}
            return ModuleResult;
        }        
    }
}
