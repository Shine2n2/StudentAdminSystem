using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAdministrationSystem.UserInterface
{
    public class GlobalViewsUI
    {
        public void Header()
        {
            Console.WriteLine("");
            var header = new ConsoleTable("                                                               STUDENT ADMINISTRATION SYSTEM ");
            header.Write(Format.MarkDown);
        }
    }
}
