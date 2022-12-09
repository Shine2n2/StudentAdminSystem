using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAdministrationSystem.ViewModel
{
    public class ProgrammeSummaryViewModel
    {
        public string DegreeProgrammeId { get; set; }
        public string DegreeProgrammeResultStatus { get; set; }
        public int ProgrammeScore { get; set; }
        public string Cohort { get; set; }
        public string StudentId { get; set; }
    }
}
