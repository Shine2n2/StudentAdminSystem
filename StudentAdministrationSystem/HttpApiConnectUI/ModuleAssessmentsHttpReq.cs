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
    public class ModuleAssessmentsHttpReq
    {   
        public ModuleAssessments[] GETModuleAssessmentbyModAssessmentIdHttp(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse response = (WebResponse)request.GetResponse();
            var output = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var outputJson = JsonConvert.DeserializeObject<ModuleAssessments[]>(output);
            return outputJson;
        }


        public void GetAllModuleAssessmentsUI()
        {
            var url = $"https://localhost:44306/api/ModuleAssessments/GetAllModulesAssessment";
            var output = GETModuleAssessmentbyModAssessmentIdHttp(url);
            var table = new ConsoleTable("MODULE ASSESSMENT ID", "MODULE ASSESSMENT TITLE", "PROGRAMME MODULE ID");
            foreach (var x in output)
            {
                table.AddRow(x.ModuleAssessmentsId,x.ModuleAssessmentsTitle, x.ProgrammeModuleId);
            }
            table.Write(Format.Alternative);
        }

        public void GetModuleAssessmentsByModAssessmentIdUI(string modAssessmentId)
        {
            var url = $"https://localhost:44306/api/ModuleAssessments/GetModulesAssessmentByModAssessmentId?ModAssessmentId={modAssessmentId}";
            var output = GETModuleAssessmentbyModAssessmentIdHttp(url);
            var table = new ConsoleTable("MODULE ASSESSMENT ID", "MODULE ASSESSMENT TITLE", "PROGRAMME MODULE ID");
            foreach (var x in output)
            {
                table.AddRow(x.ModuleAssessmentsId, x.ModuleAssessmentsTitle, x.ProgrammeModuleId);
            }
            table.Write(Format.Alternative);
        }

        public void GetAllModuleAssessmentByDegProgIdUI(string degProjId)
        {
            var url = $"https://localhost:44306/api/ModuleAssessments/GetModuleAssessmentByDegreeProgrammeId?DegProgId={degProjId}";
            var output = GETModuleAssessmentbyModAssessmentIdHttp(url);
            var table = new ConsoleTable("MODULE ASSESSMENT ID", "MODULE ASSESSMENT TITLE", "PROGRAMME MODULE ID");
            foreach (var x in output)
            {
                table.AddRow(x.ModuleAssessmentsId, x.ModuleAssessmentsTitle, x.ProgrammeModuleId);
            }
            table.Write(Format.Alternative);
        }
    }
}
