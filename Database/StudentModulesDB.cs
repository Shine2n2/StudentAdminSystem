using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class StudentModulesDB
    {
        public List<StudentModules> StudentModuleData()
        {
            List<StudentModules> studentModules = new List<StudentModules>
            {
                new StudentModules{ProgrammeModuleId ="MOD234544", StudentId = "2021302634", StudentModuleMark = 70, ProgrammeModuleTitle = "MOD2", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD334545", StudentId = "2021302634", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD3", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD434345", StudentId = "2021302634", StudentModuleMark = 50, ProgrammeModuleTitle = "MOD4", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD534245", StudentId = "2021302634", StudentModuleMark = 40, ProgrammeModuleTitle = "MOD5", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD634546", StudentId = "2021302634", StudentModuleMark = 30, ProgrammeModuleTitle = "MOD6", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD134543", StudentId = "2021302634", StudentModuleMark = 20, ProgrammeModuleTitle = "MOD1", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD122545", StudentId = "2021302635", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD1", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD322546", StudentId = "2021302635", StudentModuleMark = 20, ProgrammeModuleTitle = "MOD3", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD522547", StudentId = "2021302635", StudentModuleMark = 72, ProgrammeModuleTitle = "MOD5", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD222537", StudentId = "2021302635", StudentModuleMark = 37, ProgrammeModuleTitle = "MOD2", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD622537", StudentId = "2021302635", StudentModuleMark = 50, ProgrammeModuleTitle = "MOD6", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD422321", StudentId = "2021302635", StudentModuleMark = 40, ProgrammeModuleTitle = "MOD4", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD122545", StudentId = "2021302636", StudentModuleMark = 50, ProgrammeModuleTitle = "MOD1", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD322546", StudentId = "2021302636", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD3", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD522547", StudentId = "2021302636", StudentModuleMark = 70, ProgrammeModuleTitle = "MOD5", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD222537", StudentId = "2021302636", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD2", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD622537", StudentId = "2021302636", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD6", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD422321", StudentId = "2021302636", StudentModuleMark = 40, ProgrammeModuleTitle = "MOD4", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD222333", StudentId = "2021302637", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD2", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD422333", StudentId = "2021302637", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD4", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD622333", StudentId = "2021302637", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD6", IsCore = true },
                new StudentModules{ProgrammeModuleId ="MOD124233", StudentId = "2021302637", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD1", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD324233", StudentId = "2021302637", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD3", IsCore = false },
                new StudentModules{ProgrammeModuleId ="MOD524233", StudentId = "2021302637", StudentModuleMark = 60, ProgrammeModuleTitle = "MOD5", IsCore = false },
            };
            return studentModules;
        }
    }
}
