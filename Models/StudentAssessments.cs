using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class StudentAssessments
    {
        public string ModuleAssessmentsId { get; set; }
        public string ModuleAssessmentsTitle { get; set; }
        public int StudentAssessmentScore { get; set; }
        public bool IsUndefined { get; set; }
        public string ProgrammeModuleId { get; set; }
        public string StudentId { get; set; }

    }
}
