using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ProgrammeSummaryRepo
    {
        ProgrammeSummaryDB _programmeSummaryDB = new ProgrammeSummaryDB();
        public List<ProgrammeSummary> GetAllProgrammeSummary()
        {
            return _programmeSummaryDB.ProgrammeSummariesData();
        }
        public List<ProgrammeSummary> GetProgrammeSummaryByStudentId(string studentId)
        {
            if (_programmeSummaryDB.ProgrammeSummariesData().Any(x => x.StudentId == studentId))
            {
                var result = from x in _programmeSummaryDB.ProgrammeSummariesData() where x.StudentId == studentId select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {studentId}");
        }

        public ProgrammeSummary CreateProgrammeSummary(ProgrammeSummary programmeSummary)
        {
            _programmeSummaryDB.ProgrammeSummariesData().Add(programmeSummary);
            return programmeSummary;
        }
    }
}
