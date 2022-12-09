using ConsoleTables;
using StudentAdministrationSystem.UserInterface;
using System;
using System.Data;

namespace StudentAdministrationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            ProgramEntry startApp = new ProgramEntry();
            startApp.StartUI();
           
        }
    }
}
