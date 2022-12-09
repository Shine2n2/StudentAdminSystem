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
    public class DegreeProgrammeHttpReq
    {     
        public DegreeProgramme[] GETDegreeProgrammeHttp(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse response = (WebResponse)request.GetResponse();
            var output = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var outputJson = JsonConvert.DeserializeObject<DegreeProgramme[]>(output);
            return outputJson;
        }


        public void DegreeProgrammeByDegProgIdUI(string DegProgId)
        {            
            var url = $"https://localhost:44306/api/DegreeProgramme/GetDegreeProgrammeByDegreeProgrammeId?DegProgId={DegProgId}";
            var output = GETDegreeProgrammeHttp(url);
            var table = new ConsoleTable("DEGREE PROGRAMME ID", "DEGREE PROGRAMME TITLE", "DURATION");
            foreach (var x in output)
            {
                table.AddRow(x.DegreeProgrammeId,x.DegreeProgrammeTitle,x.DegreeProgrammeDuration);
            }
            table.Write(Format.Alternative);
        }

        public void GetAllDegreeProgrammeUI()
        {
            var url = $"https://localhost:44306/api/DegreeProgramme/GetAllProgrammeModules";
            var output = GETDegreeProgrammeHttp(url);
            var table = new ConsoleTable("DEGREE PROGRAMME ID", "DEGREE PROGRAMME TITLE", "DURATION");
            foreach (var x in output)
            {
                table.AddRow(x.DegreeProgrammeId, x.DegreeProgrammeTitle, x.DegreeProgrammeDuration);
            }
            table.Write(Format.Alternative);
        }

        public void GetAllDegreeProgrammeInputReq()
        {
            var url = $"https://localhost:44306/api/DegreeProgramme/GetAllProgrammeModules";
            var output = GETDegreeProgrammeHttp(url);
            var table = new ConsoleTable("DEGREE PROGRAMME ID", "DEGREE PROGRAMME TITLE", "DURATION");
            foreach (var x in output)
            {
                table.AddRow(x.DegreeProgrammeId, x.DegreeProgrammeTitle, x.DegreeProgrammeDuration);
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            table.Write(Format.MarkDown);
            Console.ResetColor();
        }

        public DegreeProgramme[] DegreeProgrammeByDegProgIdSearch(string DegProgId)
        {
            var url = $"https://localhost:44306/api/DegreeProgramme/GetDegreeProgrammeByDegreeProgrammeId?DegProgId={DegProgId}";
            var output = GETDegreeProgrammeHttp(url);

            //foreach (var x in output)
            //{
            //    table.AddRow(x.DegreeProgrammeId, x.DegreeProgrammeTitle, x.DegreeProgrammeDuration);
            //}
            //table.Write(Format.Alternative);
            return output;
        }

    }
}
