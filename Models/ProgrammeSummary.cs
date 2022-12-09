using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ProgrammeSummary
    {
        public string DegreeProgrammeId { get; set; }
        public string DegreeProgrammeResultStatus { get; set; }
        public int ProgrammeScore { get; set; }
        public string Cohort { get; set; }
        public string StudentId { get; set; }
    }
}
