using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAdministrationSystem.ViewModel
{
    public class ProgrammeModulesViewModel
    {
        public string ProgrammeModuleId { get; set; }
        public string ProgrammeModuleTitle { get; set; }
        public bool IsCore { get; set; }
        public string DegreeProgrammeId { get; set; }   
    }
}
