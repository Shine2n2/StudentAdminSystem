using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class ProgrammeSummaryDB
    {
        public List<ProgrammeSummary> ProgrammeSummariesData()
        {
            List<ProgrammeSummary> programmeSummaries = new List<ProgrammeSummary>
            {
                new ProgrammeSummary{DegreeProgrammeId = "200180", DegreeProgrammeResultStatus = "Distinction", Cohort = "2021", StudentId = "2021302634", ProgrammeScore = 60},
                new ProgrammeSummary{DegreeProgrammeId = "500330", DegreeProgrammeResultStatus = "Distinction", Cohort = "2021", StudentId = "2021302637", ProgrammeScore = 70},
                new ProgrammeSummary{DegreeProgrammeId = "300222", DegreeProgrammeResultStatus = "Distinction", Cohort = "2021", StudentId = "2021302635", ProgrammeScore = 50},
                new ProgrammeSummary{DegreeProgrammeId = "400120", DegreeProgrammeResultStatus = "Distinction", Cohort = "2021", StudentId = "2021302636", ProgrammeScore = 50}
            };
            return programmeSummaries;
        }
    }
}
