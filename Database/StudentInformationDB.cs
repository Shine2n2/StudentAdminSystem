using Models;
using System;
using System.Collections.Generic;

namespace Database
{
    public class StudentInformationDB
    {
        public List<StudentInformation> StudentInformationsData()
        {
            List<StudentInformation> studentInfos = new List<StudentInformation>
            {
                new StudentInformation{StudentId = "2021302634", FirstName = "CHIBUIKE", LastName = "CHUKWU", DegreeProgrammeDuration = 1, DegreeProgrammeId = "200180", DegreeProgrammeTitle = "COMPUTER SCIENCE", YearOfStudy = "2021", FullName = "CHIBUIKE CHUKWU"},
                new StudentInformation{StudentId = "2021302635", FirstName = "GEORGE", LastName = "BUSH", DegreeProgrammeDuration = 2, DegreeProgrammeId = "300222", DegreeProgrammeTitle = "ARTIFICIAL INTELLIGENCE", YearOfStudy = "2021", FullName = "GEORGE BUSH"},
                new StudentInformation{StudentId = "2021302636", FirstName = "MARTINS", LastName = "TOM", DegreeProgrammeDuration = 1, DegreeProgrammeId = "400120", DegreeProgrammeTitle = "DATA ANALYSIS", YearOfStudy = "2021", FullName = "MARTINS TOM"},
                new StudentInformation{StudentId = "2021302637", FirstName = "CRAIG", LastName = "DAVID", DegreeProgrammeDuration = 2, DegreeProgrammeId = "500330", DegreeProgrammeTitle = "CYBER SECURITY", YearOfStudy = "2021", FullName = "CRAIG DAVID"},                
            };
            return studentInfos;
        }
    }
}
