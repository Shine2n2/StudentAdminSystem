using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAdministrationSystem.ViewModel
{
    public class StudentModulesViewModel
    {
        public string ProgrammeModuleId { get; set; }
        public string ProgrammeModuleTitle { get; set; }
        public bool IsCore { get; set; }        
        public int StudentModuleMark { get; set; }        
        public string StudentId { get; set; }
    }
}
