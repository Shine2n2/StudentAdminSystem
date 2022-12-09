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
    public class ProgrammeSummaryHttpReq
    {        
        public ProgrammeSummary[] GETProgrammeSummaryHttp(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse response = (WebResponse)request.GetResponse();
            var output = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var outputJson = JsonConvert.DeserializeObject<ProgrammeSummary[]>(output);
            return outputJson;
        }

        public void GetAllProgrammeSummaryUI()
        {
            var url = $"https://localhost:44306/api/ProgrammeSummaries/GetAllProgrammeSummary";
            var output = GETProgrammeSummaryHttp(url);
            var table = new ConsoleTable("DEGREE PROGRAMME ID", "STUDENT ID", "DEGREE PROGRAMME STATUS", "PROGRAMME SCORE", "COHORT");
            foreach (var x in output)
            {
                table.AddRow(x.DegreeProgrammeId,x.StudentId,x.DegreeProgrammeResultStatus,x.ProgrammeScore,x.Cohort);
            }
            table.Write(Format.Alternative);
        }

        public void GetProgrammeSummaryByStudentIdUI(string studentId)
        {
            var url = $"https://localhost:44306/api/ProgrammeSummaries/GetProgrammeSummaryByStudentId?studentId={studentId}";
            var output = GETProgrammeSummaryHttp(url);
            var table = new ConsoleTable("DEGREE PROGRAMME ID", "STUDENT ID", "DEGREE PROGRAMME STATUS", "PROGRAMME SCORE", "COHORT");
            foreach (var x in output)
            {
                table.AddRow(x.DegreeProgrammeId, x.StudentId, x.DegreeProgrammeResultStatus, x.ProgrammeScore, x.Cohort);
            }
            table.Write(Format.Alternative);
        }

        public void GetProgrammeSummaryByStudentIdUI2(string studentId)
        {
            var url = $"https://localhost:44306/api/ProgrammeSummaries/GetProgrammeSummaryByStudentId?studentId={studentId}";
            var output = GETProgrammeSummaryHttp(url);
            var table = new ConsoleTable(" CURRENT DEGREE PROGRAMME SUMMARY    ");
            foreach (var x in output)
            {
                table.AddRow($"Programme Score:   {x.ProgrammeScore}\n");
                table.AddRow($"Programme Remark:  {x.DegreeProgrammeResultStatus}");
            }
            table.Write(Format.Minimal);
            Console.WriteLine("-------------------------------------");
        }
    }
}
