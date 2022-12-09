using Database;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class DegreeProgrammeRepo
    {
        DegreeProgrammeDB _degreeProgrammeDB = new DegreeProgrammeDB();
        public List<DegreeProgramme> GetAllDegreeProgramme()
        {
            return _degreeProgrammeDB.DegreeProgrammeData();
        }

        public List<DegreeProgramme> GetDegreeProgrammeByDegreeProgrammeId(string degreeProgrammeId)
        {
            if (_degreeProgrammeDB.DegreeProgrammeData().Any(x => x.DegreeProgrammeId == degreeProgrammeId))
            {
                var result = from x in _degreeProgrammeDB.DegreeProgrammeData() where x.DegreeProgrammeId == degreeProgrammeId select x;
                return result.ToList();
            }
            
            throw new Exception($"No Existing record with Id {degreeProgrammeId}");
        }        
    }
}
