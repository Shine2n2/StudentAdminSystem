using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class DegreeProgrammeDB
    {
        public List<DegreeProgramme> DegreeProgrammeData()
        {
            List<DegreeProgramme> degreeProgramme = new List<DegreeProgramme>
            {
                new DegreeProgramme{  DegreeProgrammeId = "200180", DegreeProgrammeTitle = "COMPUTER SCIENCE", DegreeProgrammeDuration = 1},
                new DegreeProgramme{  DegreeProgrammeId = "300222", DegreeProgrammeTitle = "ARTIFICIAL INTELLIGENCE", DegreeProgrammeDuration = 2},
                new DegreeProgramme{  DegreeProgrammeId = "400120", DegreeProgrammeTitle = "DATA ANALYSIS", DegreeProgrammeDuration = 1},
                new DegreeProgramme{  DegreeProgrammeId = "500330", DegreeProgrammeTitle = "CYBER SECURITY", DegreeProgrammeDuration = 2}, 
            };
            return degreeProgramme;
        }
    }
}
