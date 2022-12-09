using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class ProgrammeModulesDB
    {
        public List<ProgrammeModules> ProgrammeModuleData()
        {
            List<ProgrammeModules> programmeModules = new List<ProgrammeModules>
            {
				new ProgrammeModules { ProgrammeModuleId = "MOD134543", ProgrammeModuleTitle = "MOD1",DegreeProgrammeId = "200180", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD234544", ProgrammeModuleTitle = "MOD2",DegreeProgrammeId = "200180", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD334545", ProgrammeModuleTitle = "MOD3",DegreeProgrammeId = "200180", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD434345", ProgrammeModuleTitle = "MOD4",DegreeProgrammeId = "200180", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD534245", ProgrammeModuleTitle = "MOD5",DegreeProgrammeId = "200180", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD634546", ProgrammeModuleTitle = "MOD6",DegreeProgrammeId = "200180", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD734547", ProgrammeModuleTitle = "MOD7",DegreeProgrammeId = "200180", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD834548", ProgrammeModuleTitle = "MOD8",DegreeProgrammeId = "200180", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD122545", ProgrammeModuleTitle = "MOD1",DegreeProgrammeId = "400120", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD322546", ProgrammeModuleTitle = "MOD3",DegreeProgrammeId = "400120", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD522547", ProgrammeModuleTitle = "MOD5",DegreeProgrammeId = "400120", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD222537", ProgrammeModuleTitle = "MOD2",DegreeProgrammeId = "400120", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD622537", ProgrammeModuleTitle = "MOD6",DegreeProgrammeId = "400120", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD422321", ProgrammeModuleTitle = "MOD4",DegreeProgrammeId = "400120", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD722311", ProgrammeModuleTitle = "MOD7",DegreeProgrammeId = "400120", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD822111", ProgrammeModuleTitle = "MOD8",DegreeProgrammeId = "400120", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD922333", ProgrammeModuleTitle = "MOD9",DegreeProgrammeId = "400120", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD222333", ProgrammeModuleTitle = "MOD2",DegreeProgrammeId = "500330", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD422333", ProgrammeModuleTitle = "MOD4",DegreeProgrammeId = "500330", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD622333", ProgrammeModuleTitle = "MOD6",DegreeProgrammeId = "500330", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD124233", ProgrammeModuleTitle = "MOD1",DegreeProgrammeId = "500330", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD324233", ProgrammeModuleTitle = "MOD3",DegreeProgrammeId = "500330", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD524233", ProgrammeModuleTitle = "MOD5",DegreeProgrammeId = "500330", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD724233", ProgrammeModuleTitle = "MOD7",DegreeProgrammeId = "500330", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD824233", ProgrammeModuleTitle = "MOD8",DegreeProgrammeId = "500330", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD924233", ProgrammeModuleTitle = "MOD9",DegreeProgrammeId = "500330", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD224233", ProgrammeModuleTitle = "MOD2",DegreeProgrammeId = "300222", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD524233", ProgrammeModuleTitle = "MOD5",DegreeProgrammeId = "300222", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD724233", ProgrammeModuleTitle = "MOD7",DegreeProgrammeId = "300222", IsCore = true },
				new ProgrammeModules { ProgrammeModuleId = "MOD124233", ProgrammeModuleTitle = "MOD1",DegreeProgrammeId = "300222", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD311233", ProgrammeModuleTitle = "MOD3",DegreeProgrammeId = "300222", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD414233", ProgrammeModuleTitle = "MOD4",DegreeProgrammeId = "300222", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD612233", ProgrammeModuleTitle = "MOD6",DegreeProgrammeId = "300222", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD894233", ProgrammeModuleTitle = "MOD8",DegreeProgrammeId = "300222", IsCore = false },
				new ProgrammeModules { ProgrammeModuleId = "MOD987233", ProgrammeModuleTitle = "MOD9",DegreeProgrammeId = "300222", IsCore = false },
			};
            return programmeModules;
        }
    }
}

