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
    public class StudentModulesHttpReq
    {   
        public StudentModules[] GETStudentModulesHttp(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse response = (WebResponse)request.GetResponse();
            var output = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var outputJson = JsonConvert.DeserializeObject<StudentModules[]>(output);
            return outputJson;
        }

        public void GetAllStudentModulesUI()
        {
            var url = $"https://localhost:44306/api/StudentModules/GetAllStudentModule";
            var output = GETStudentModulesHttp(url);
            var table = new ConsoleTable("PROGRAMME MODULE ID", "STUDENT ID", "PROGRAMME MODULE TITLE", "STUDENT MODULE MARK", "IS A CORE MODULE");
            foreach (var x in output)
            {
                table.AddRow(x.ProgrammeModuleId, x.StudentId, x.ProgrammeModuleTitle, x.StudentModuleMark, x.IsCore);   
            }
            table.Write(Format.Alternative);
        }

        public void GetStudentModulesByStudentIdUI(string studentId)
        {
            var url = $"https://localhost:44306/api/StudentModules/GetStudentModuleByStudentId?studentId={studentId}";
            var output = GETStudentModulesHttp(url);
            var table = new ConsoleTable("PROGRAMME MODULE ID", "STUDENT ID", "PROGRAMME MODULE TITLE", "STUDENT MODULE MARK", "IS A CORE MODULE");
            foreach (var x in output)
            {
                table.AddRow(x.ProgrammeModuleId, x.StudentId, x.ProgrammeModuleTitle, x.StudentModuleMark, x.IsCore);
            }
            table.Write(Format.Alternative);
        }

        public void GetStudentModulesByStudentIdUI2(string studentId)
        {
            var url = $"https://localhost:44306/api/StudentModules/GetStudentModuleByStudentId?studentId={studentId}";
            var output = GETStudentModulesHttp(url);
            var table = new ConsoleTable("PROGRAMME MODULE ID", "PROGRAMME MODULE TITLE", "STUDENT MODULE MARK", "IS A CORE MODULE");
            foreach (var x in output)
            {
                table.AddRow(x.ProgrammeModuleId, x.ProgrammeModuleTitle, x.StudentModuleMark, x.IsCore);
            }
            table.Write(Format.Alternative);
        }


        public void GetStudentModulesByProgModIdUI(string progModId)
        {
            var url = $"https://localhost:44306/api/StudentModules/GetStudentModuleByProgrammeModId?programmeModId={progModId}";
            var output = GETStudentModulesHttp(url);
            var table = new ConsoleTable("PROGRAMME MODULE ID", "STUDENT ID", "PROGRAMME MODULE TITLE", "STUDENT MODULE MARK", "IS A CORE MODULE");
            foreach (var x in output)
            {
                table.AddRow(x.ProgrammeModuleId, x.StudentId, x.ProgrammeModuleTitle, x.StudentModuleMark, x.IsCore);
            }
            table.Write(Format.Alternative);
        }
    }
}
