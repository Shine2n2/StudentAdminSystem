using ConsoleTables;
using Models;
using Newtonsoft.Json;
using StudentAdministrationSystem.UserInterface;
using StudentAdministrationSystem.ViewModel;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace StudentAdministrationSystem.HttpApiConnectUI
{
    public class StudentInformationHttpReq
    {      
        public StudentInformation[] GETStudentInformationHttp(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse response = (WebResponse)request.GetResponse();
            var output = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var outputJson = JsonConvert.DeserializeObject<StudentInformation[]>(output);
            return outputJson;
        }

        public void GetAllStudentInformationUI()
        {
            var url = $"https://localhost:44306/api/StudentInformation/GetAllStudents";
            var output = GETStudentInformationHttp(url);
            var table = new ConsoleTable("FIRST NAME", "LAST NAME", "STUDENT ID", "PROGRAMME TITLE", "DEGREE PROGRAMME ID", "PROGRAMME DURATION", "COHORT");
            foreach (var x in output)
            {
                table.AddRow(x.FirstName, x.LastName, x.StudentId, x.DegreeProgrammeTitle, x.DegreeProgrammeId, x.DegreeProgrammeDuration, x.YearOfStudy);
            }
            table.Write(Format.Alternative);
        }

        public void GetStudentInformationByStudentIdUI(string studentId)
        {
            var url = $"https://localhost:44306/api/StudentInformation/GetStudentbystudentId?studentId={studentId}";
            var output = GETStudentInformationHttp(url);
            var table = new ConsoleTable("FIRST NAME", "LAST NAME", "STUDENT ID", "PROGRAMME TITLE", "DEGREE PROGRAMME ID","PROGRAMME DURATION", "COHORT");
            foreach (var x in output)
            {
                table.AddRow(x.FirstName, x.LastName, x.StudentId, x.DegreeProgrammeTitle, x.DegreeProgrammeId, x.DegreeProgrammeDuration, x.YearOfStudy);
            }
            table.Write(Format.Alternative);
        }

        public void GetStudentInformationByProgIdUI(string degProgId)
        {
            var url = $"https://localhost:44306/api/StudentInformation/GetStudentByProgrammeId?DegreeProgrammeId={degProgId}";
            var output = GETStudentInformationHttp(url);
            var table = new ConsoleTable("FIRST NAME", "LAST NAME", "STUDENT ID", "PROGRAMME TITLE", "DEGREE PROGRAMME ID", "PROGRAMME DURATION", "COHORT");
            foreach (var x in output)
            {
                table.AddRow(x.FirstName, x.LastName, x.StudentId, x.DegreeProgrammeTitle, x.DegreeProgrammeId, x.DegreeProgrammeDuration, x.YearOfStudy);
            }
            table.Write(Format.Alternative);
        }

        public void GetStudentInformationByCohortUI(string cohort)
        {
            var url = $"https://localhost:44306/api/StudentInformation/GetStudentByCohort?yearOfStudy={cohort}";
            var output = GETStudentInformationHttp(url);
            var table = new ConsoleTable("FIRST NAME", "LAST NAME", "STUDENT ID", "PROGRAMME TITLE", "DEGREE PROGRAMME ID", "PROGRAMME DURATION", "COHORT");
            foreach (var x in output)
            {
                table.AddRow(x.FirstName, x.LastName, x.StudentId, x.DegreeProgrammeTitle, x.DegreeProgrammeId, x.DegreeProgrammeDuration, x.YearOfStudy);
            }
            table.Write(Format.Alternative);
        }

        public void GetStudentInformationByDurationUI(int duration)
        {
            var url = $"https://localhost:44306/api/StudentInformation/GetStudentByDuration?duration={duration}";
            var output = GETStudentInformationHttp(url);
            var table = new ConsoleTable("FIRST NAME", "LAST NAME", "STUDENT ID", "PROGRAMME TITLE", "DEGREE PROGRAMME ID", "PROGRAMME DURATION", "COHORT");
            foreach (var x in output)
            {
                table.AddRow(x.FirstName, x.LastName, x.StudentId, x.DegreeProgrammeTitle, x.DegreeProgrammeId, x.DegreeProgrammeDuration, x.YearOfStudy);
            }
            table.Write(Format.Alternative);
        }

        public void POSTCreateStudentInformationUI(StudentInformationViewModel studentObj)
        {
            GlobalViewsUI topDisplay = new GlobalViewsUI();
            ProgramEntry programEntry = new ProgramEntry();
            var url = $"https://localhost:44306/api/StudentInformation/CreateNewStudentRecord";
          
            using (var client = new HttpClient())
            {
                var endpoint = new Uri(url);
                var newPostJson = JsonConvert.SerializeObject(studentObj);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
                var output = JsonConvert.DeserializeObject<StudentInformationViewModel>(result);

                if(output != null)
                {
                    Console.Clear();
                    topDisplay.Header();
                    Console.WriteLine("Registration was Successful, find details below!");
                    var table = new ConsoleTable("FULLNAME", "STUDENT ID", "PROGRAMME TITLE", "DEGREE PROGRAMME ID", "PROGRAMME DURATION", "COHORT");
                    table.AddRow(output.FullName, output.StudentId, output.DegreeProgrammeTitle, output.DegreeProgrammeId, output.DegreeProgrammeDuration, output.YearOfStudy);
                    table.Write(Format.Alternative);
                    programEntry.NextActionRequest();
                }
                else 
                {
                    Console.Clear();
                    topDisplay.Header();
                    Console.WriteLine("Registration not successful, please try again !");
                    programEntry.NextActionRequest();
                }               
            }
        }

        public void POSTDeleteStudentInformationByStudentUI()
        {
            var url = $"https://localhost:44370/api/StudentDetails/get-student-detail-by-programmeId?programmeId=";
            var output = GETStudentInformationHttp(url);           
        }
    }
}
