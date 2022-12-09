using ConsoleTables;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Utilities;

namespace StudentAdministrationSystem.HttpApiConnectUI
{
    public class StudentAssessmentsHttpReq
    {
        ProgrammeSummaryComputation _programmeSummary = new ProgrammeSummaryComputation();
        public StudentAssessments[] GETStudentAssessmentsHttp(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse response = (WebResponse)request.GetResponse();
            var output = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var outputJson = JsonConvert.DeserializeObject<StudentAssessments[]>(output);
            return outputJson;
        }

        public void GetAllStudentAssessmentsUI()
        {
            string remark;
            var url = $"https://localhost:44306/api/StudentAssessments/GetAllStudentAssessmenet";
            var output = GETStudentAssessmentsHttp(url);
            var table = new ConsoleTable("STUDENT ID", "MODULE ASSESSMENT ID", "MODULE ASSESSMENT TITLE", "MODULE ASSESSMENT SCORE", "REMARK", "PROGRAMME MODULE ID");
            foreach (var x in output)
            {
                remark = _programmeSummary.ModuleResult(x.StudentAssessmentScore);
                table.AddRow(x.StudentId,x.ModuleAssessmentsId,x.ModuleAssessmentsTitle,x.StudentAssessmentScore,remark, x.ProgrammeModuleId);
            }
            table.Write(Format.Alternative);
        }

        public void GetStudentAssessmentsByStudentIdUI(string studentId)
        {
            string remark;
            var url = $"https://localhost:44306/api/StudentAssessments/GetStudentAssessmentByStudentId?studentId={studentId}";
            var output = GETStudentAssessmentsHttp(url);
            var table = new ConsoleTable("STUDENT ID", "MODULE ASSESSMENT ID", "MODULE ASSESSMENT TITLE", "MODULE ASSESSMENT SCORE","REMARK", "PROGRAMME MODULE ID");
            foreach (var x in output)
            {
                remark =_programmeSummary.ModuleResult(x.StudentAssessmentScore);
                table.AddRow(x.StudentId, x.ModuleAssessmentsId, x.ModuleAssessmentsTitle, x.StudentAssessmentScore, remark, x.ProgrammeModuleId);
            }
            table.Write(Format.Alternative);
        }

        public void GetStudentAssessmentsByStudentIdUI2(string studentId)
        {
            string remark;
            var url = $"https://localhost:44306/api/StudentAssessments/GetStudentAssessmentByStudentId?studentId={studentId}";
            var output = GETStudentAssessmentsHttp(url);
            var table = new ConsoleTable("MODULE ASSESSMENT ID", "MODULE ASSESSMENT TITLE", "MODULE ASSESSMENT SCORE", "REMARK");
            foreach (var x in output)
            {
                remark = _programmeSummary.ModuleResult(x.StudentAssessmentScore);
                table.AddRow(x.ModuleAssessmentsId, x.ModuleAssessmentsTitle, x.StudentAssessmentScore, remark);
            }
            table.Write(Format.Alternative);
        }
    }
}
