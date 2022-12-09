using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ProgrammeModulesRepo
    {
        ProgrammeModulesDB _programmeModulesDB = new ProgrammeModulesDB();
        public List<ProgrammeModules> GetAllProgrammeModules()
        {
            return _programmeModulesDB.ProgrammeModuleData();
        }
        public List<ProgrammeModules> GetProgrammeModuleByProgModId(string ProgId)
        {
            if (_programmeModulesDB.ProgrammeModuleData().Any(x => x.ProgrammeModuleId == ProgId))
            {
                var result = from x in _programmeModulesDB.ProgrammeModuleData() where x.ProgrammeModuleId == ProgId select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {ProgId}");

        }
        public List<ProgrammeModules> GetProgrammeModuleByDegreeProgrammeId(string degreeProgrammeid)
        {
            if (_programmeModulesDB.ProgrammeModuleData().Any(x => x.DegreeProgrammeId == degreeProgrammeid))
            {
                var result = from x in _programmeModulesDB.ProgrammeModuleData() where x.DegreeProgrammeId == degreeProgrammeid select x;
                return result.ToList();
            }
            throw new Exception($"No Existing record with Id {degreeProgrammeid}");
        }
    }
}
