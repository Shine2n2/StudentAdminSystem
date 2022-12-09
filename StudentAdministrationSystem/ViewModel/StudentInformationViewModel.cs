using System;

namespace StudentAdministrationSystem.ViewModel
{
    public class StudentInformationViewModel
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DegreeProgrammeTitle { get; set; }
        public string DegreeProgrammeId { get; set; }
        public int DegreeProgrammeDuration { get; set; }
        public string YearOfStudy { get; set; }
        public string FullName { get; set; }                  
    }
}
