using ConsoleTables;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StudentAdministrationSystem.HttpApiConnectUI
{
    public class ProgrammeModulesHttpReq
    {
        public ProgrammeModules[] GETProgrammeModulesHttp(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse response = (WebResponse)request.GetResponse();
            var output = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var outputJson = JsonConvert.DeserializeObject<ProgrammeModules[]>(output);
            return outputJson;
        }

        public void GetAllProgrammeModulesUI()
        {
            var url = $"https://localhost:44306/api/ProgrammeModules/GetAllProgrammeModules";
            var output = GETProgrammeModulesHttp(url);
            var table = new ConsoleTable("DEGREE PROGRAMME ID", "PROGRAMME MODULE ID", "PROGRAMME MODULE TITLE");
            foreach (var x in output)
            {
                table.AddRow(x.DegreeProgrammeId, x.ProgrammeModuleId, x.ProgrammeModuleTitle);
            }
            table.Write(Format.Alternative);
        }

        public void GETProgrammeModulesByProjModIdUI(string progModId)
        {
            var url = $"https://localhost:44306/api/ProgrammeModules/GetProgrammeModuleByProgrammeModId?ProgModId={progModId}";
            var output = GETProgrammeModulesHttp(url);
            var table = new ConsoleTable("DEGREE PROGRAMME ID", "PROGRAMME MODULE ID", "PROGRAMME MODULE TITLE");
            foreach (var x in output)
            {
                table.AddRow(x.DegreeProgrammeId, x.ProgrammeModuleId, x.ProgrammeModuleTitle);
            }
            table.Write(Format.Alternative);
        }

           
        public void GetProgrammeModuleByDegProgIdUI(string degProgId)        
        {        
            var url = $"https://localhost:44306/api/ProgrammeModules/GetProgrammeModuleByDegreeProgrammeId?degProgModId={degProgId}";
            var output = GETProgrammeModulesHttp(url);
            var table = new ConsoleTable("DEGREE PROGRAMME ID", "PROGRAMME MODULE ID", "PROGRAMME MODULE TITLE");
            foreach (var x in output)
            {
                table.AddRow(x.DegreeProgrammeId, x.ProgrammeModuleId, x.ProgrammeModuleTitle);
            }
            table.Write(Format.Alternative);
        }        
    }
}
