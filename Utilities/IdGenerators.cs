using System;

namespace Utilities
{
    public class IdGenerators
    {
        public static string CodeGenerator(int length, string codeprefix)
        {
            var random = new Random();
            string Codeprefix = codeprefix;
            for (int i = 0; i < length; i++)
            {
                Codeprefix = String.Concat(Codeprefix, random.Next(10).ToString());
            }
            return Codeprefix;
        }
        
        public string GenerateDegreeProgrammeId(string prefix)
        {
            var result = CodeGenerator(10, prefix);
            return result;
        }

        public string GenerateStudentId(string YearOfStudy)
        {
            var result = CodeGenerator(6, YearOfStudy);
            return result;
        }

        public string GenerateModuleCode(string prefix)
        {
            var result = CodeGenerator(4, prefix);
            return result;
        }



    }
}
