using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ProgrammeModules
    {
        public string ProgrammeModuleId { get; set; }
        public string ProgrammeModuleTitle { get; set; }
        public bool IsCore { get; set; }
        public string DegreeProgrammeId { get; set; }   
    }
}
