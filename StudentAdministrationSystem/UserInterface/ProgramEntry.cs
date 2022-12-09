using ConsoleTables;
using StudentAdministrationSystem.HttpApiConnectUI;
using StudentAdministrationSystem.UtilitiesUI;
using StudentAdministrationSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentAdministrationSystem.UserInterface
{
    public class ProgramEntry
    {
        InputValidator _inputValidator = new InputValidator();
        StudentInformationHttpReq _studentInformationHttpReq = new StudentInformationHttpReq();
        DegreeProgrammeHttpReq _degreeProgrammeHttpReq = new DegreeProgrammeHttpReq();
        ModuleAssessmentsHttpReq _moduleAssessmentsHttpReq = new ModuleAssessmentsHttpReq();
        ProgrammeSummaryHttpReq _programmeSummaryHttpReq = new ProgrammeSummaryHttpReq();
        StudentAssessmentsHttpReq _studentAssessmentsHttpReq = new StudentAssessmentsHttpReq();
        StudentModulesHttpReq _studentModulesHttpReq = new StudentModulesHttpReq();
        GlobalViewsUI topDisplay = new GlobalViewsUI();

      
        public void StartUI()
        {
            Console.Clear();            
            topDisplay.Header();
            string choice;
            while (true)
            {
                Console.WriteLine("Please select a function you require below:\n");
                Console.WriteLine("Type:\n  ->  AA for Student Information \n  ->  BB for Degree Programme Record \n  ->  CC for Student Assessment Record " +
                    "\n  ->  DD for Student Module Record \n  ->  EE for Complete Student Record \n  ->  NEW to Create a New Student Record \n  ->  XX to Exit");
                Console.WriteLine("Enter your choice:");
                choice = Console.ReadLine().ToUpper().Trim();
                Console.WriteLine("\n");
                if (choice == "AA")
                {                    
                    StudentInformationInputUI();
                }
                else if (choice == "BB")
                {                    
                    DegreeProgramInputUI();
                }

                else if (choice == "CC")
                {
                    StudentAssessmentsInputUI();
                }

                else if (choice == "DD")
                {
                    StudentModuleInputUI();
                }
                else if (choice == "EE")
                {
                    GetCompleteStudentRecord();
                }
                else if (choice == "NEW")
                {
                    CreateNewStudentInputUI();
                }
                else if (choice == "XX")
                {
                    Environment.Exit(0);                    
                }
                else
                {
                    Console.WriteLine("Invalid Entry!");
                    Console.ReadLine();
                }
                break;
            }
        }

        public void StudentInformationInputUI()
        {
            Console.Clear ();            
            topDisplay.Header();
            while (true)
            {
                Console.WriteLine("Please select a function:\n");
                Console.WriteLine("Type:\n  ->  SA to view all student Information \n  ->  SB to view student Info by student Id \n  ->  SC to view student Info by Cohort year" +
                    " \n  ->  SD to view student Info by degree programme Id \n  ->  SE to view student Info by duration \n  ->  MEN to go to Home Menu \n  ->  XX to Exit");
                Console.WriteLine("Enter your choice:");
                string choice = Console.ReadLine().ToUpper().Trim();

                if (choice == "SA")
                {
                    Console.Clear();                   
                    topDisplay.Header();
                    Console.WriteLine("All Student Information");
                    _studentInformationHttpReq.GetAllStudentInformationUI();
                    NextActionRequest();
                }
                else if (choice == "SB")
                {
                    string studentId;
                    while (true)
                    {
                        Console.WriteLine("Please Enter student Id: ");
                        studentId = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateOnlyDigit(studentId))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Student Information");
                            _studentInformationHttpReq.GetStudentInformationByStudentIdUI(studentId);
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry");
                    }
                }
                else if (choice == "SC")
                {
                    string cohort;
                    while (true)
                    {
                        Console.WriteLine("Enter cohort: ");
                        cohort = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateOnlyDigit(cohort))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Student Information");
                            _studentInformationHttpReq.GetStudentInformationByCohortUI(cohort);
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry");
                    }
                }
                else if (choice == "SD")
                {
                    string progId;
                    while (true)
                    {
                        Console.WriteLine("Please Enter degree programme Id: ");
                        progId = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateNumberAndLetter(progId))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Student Information");
                            _studentInformationHttpReq.GetStudentInformationByProgIdUI(progId);
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry");
                    }
                }
                else if (choice == "SE")
                {
                    string durationInput;
                    while (true)
                    {
                        Console.WriteLine("Please Enter programme duration: ");
                        durationInput = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateOnlyDigit(durationInput))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Student Information");
                            int.TryParse(durationInput, out int duration);
                            _studentInformationHttpReq.GetStudentInformationByDurationUI(duration);
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry!");
                    }
                }
                else if (choice == "MEN")
                {
                    StartUI();
                }
                else if (choice == "XX")
                {
                    Environment.Exit(0);
                }
                else 
                {
                    Console.WriteLine("Invalid entry!");
                    Console.ReadLine();
                }
            }
        }

        public void DegreeProgramInputUI()
        {
            Console.Clear();
            topDisplay.Header();
            string choice;
            while (true)
            {
                Console.WriteLine("Please select a function:\n");
                Console.WriteLine("Type:\n  ->  DA to view all Degree Programmes \n  ->  DB to view Degree Programme by Degree Programme Id \n  ->  MEN to go to Home Menu  \n  ->  XX to Exit");
                Console.WriteLine("Enter your choice:");
                choice = Console.ReadLine().ToUpper().Trim();
                if (choice == "DA")
                {
                    Console.Clear();
                    topDisplay.Header();
                    Console.WriteLine("Degree Programme Details");
                    _degreeProgrammeHttpReq.GetAllDegreeProgrammeUI();
                    NextActionRequest();
                }
                else if (choice == "DB")
                {
                    string degProgId;
                    while (true)
                    {
                        Console.WriteLine("Please Enter degree programme Id: ");
                        degProgId = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateNumberAndLetter(degProgId))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Degree Programme Detail");
                            _degreeProgrammeHttpReq.DegreeProgrammeByDegProgIdUI(degProgId);
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry");
                    }
                }
                else if (choice == "MEN")
                {
                    StartUI();
                }
                else if (choice == "XX")
                {
                    Environment.Exit(0);
                }
                else { Console.WriteLine("Invalid entry"); }
            }
        }

        public void StudentAssessmentsInputUI()
        {
            Console.Clear();
            topDisplay.Header();
            string choice;
            while (true)
            {
                Console.WriteLine("Please select a function:\n");
                Console.WriteLine("Type:\n  ->  BA to view all Student assessments \n  ->  BB view stuent assessment by student Id" +
                    "  \n  ->  MEN to go to Home Menu  \n  ->  XX to Exit");
                Console.WriteLine("Enter your choice:");
                choice = Console.ReadLine().ToUpper().Trim();
                if (choice == "BA")
                {
                    Console.Clear();
                    topDisplay.Header();
                    Console.WriteLine("Student Assessment Details");
                    _studentAssessmentsHttpReq.GetAllStudentAssessmentsUI();
                    NextActionRequest();
                }
                else if (choice == "BB")
                {
                    string studentId;
                    while (true)
                    {
                        Console.WriteLine("Please Enter student Id: ");
                        studentId = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateOnlyDigit(studentId))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Student Assessment Details");
                            _studentAssessmentsHttpReq.GetStudentAssessmentsByStudentIdUI(studentId);
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry");
                    }
                }
                else if (choice == "XX")
                {
                    Environment.Exit(0);
                }
                else if (choice == "MEN")
                {
                    StartUI();
                }
                else { Console.WriteLine("Invalid Entry!"); }
            }
        }

        public void ProgrammeSummaryInputUI()
        {
            Console.Clear();
            topDisplay.Header();
            string choice;
            while (true)
            {
                Console.WriteLine("Please select a function\n");
                Console.WriteLine("Type:\n  ->  PA to view all programme summary \n  ->  PS to view programme sumarry by student Id" +
                    " \n ->  MEN to go to Home Menu \n  ->  XX to Exit");
                Console.WriteLine("Enter your choice:");
                choice = Console.ReadLine().ToUpper().Trim();
                if (choice == "PS")
                {
                    string studentId;
                    while (true)
                    {
                        Console.WriteLine("Please Enter student Id: ");
                        studentId = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateOnlyDigit(studentId))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Programme Summary");
                            _programmeSummaryHttpReq.GetProgrammeSummaryByStudentIdUI(studentId);
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry");
                    }
                }
                else if (choice == "PA")
                {
                    Console.Clear();
                    topDisplay.Header();
                    Console.WriteLine("Programme Summary");
                    _programmeSummaryHttpReq.GetAllProgrammeSummaryUI();
                    NextActionRequest();
                }
                else if (choice == "MEN")
                {
                    StartUI();
                }
                else if (choice == "XX")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("invalid entry");
                }
            }
        }

        public void StudentModuleInputUI()
        {
            Console.Clear();
            topDisplay.Header();
            string choice;
            while (true)
            {
                Console.WriteLine("Please select a function\n");
                Console.WriteLine("Type:\n  ->  MA to view all Student modules \n  ->  MB to view student module by student Id " +
                    " \n  ->  MC to view student module by programme module Id  \n  ->  MEN to go to Home Menu \n  ->  XX to Exit");
                Console.WriteLine("Enter your choice:");
                choice = Console.ReadLine().ToUpper().Trim();
                if (choice == "MB")
                {
                    string studentId;
                    while (true)
                    {
                        Console.WriteLine("Please Enter student Id: ");
                        studentId = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateOnlyDigit(studentId))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Student Module Detail");
                            _studentModulesHttpReq.GetStudentModulesByStudentIdUI(studentId);
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry");
                    }
                }
                else if (choice == "MC")
                {
                    string progModId;
                    while (true)
                    {
                        Console.WriteLine("Please Enter Programme module Id");
                        progModId = Console.ReadLine().Trim();
                        if (_inputValidator.ValidateNumberAndLetter(progModId))
                        {
                            Console.Clear();
                            topDisplay.Header();
                            Console.WriteLine("Student Module Details");
                            _studentModulesHttpReq.GetStudentModulesByProgModIdUI(progModId);   
                            NextActionRequest();
                            break;
                        }
                        Console.WriteLine("Invalid entry");
                    }
                }
                else if (choice == "MA")
                {
                    Console.Clear();
                    topDisplay.Header();
                    Console.WriteLine("Student Module Detail");
                    _studentModulesHttpReq.GetAllStudentModulesUI();
                    NextActionRequest();
                }
                else if (choice == "MEN")
                {
                    StartUI();
                }
                else if (choice == "XX")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
            }
        }
        public void GetCompleteStudentRecord()
        {
            Console.Clear();
            topDisplay.Header();
            string studentId;
            while (true)
            {
                Console.WriteLine("Please Enter student Id: ");
                studentId = Console.ReadLine().Trim();
                if (_inputValidator.ValidateOnlyDigit(studentId))
                {
                    Console.Clear();
                    topDisplay.Header();                   
                    Console.WriteLine("Student Information");
                    _studentInformationHttpReq.GetStudentInformationByStudentIdUI(studentId);
                    Console.WriteLine("Student Assessment Details");
                    _studentAssessmentsHttpReq.GetStudentAssessmentsByStudentIdUI2(studentId);
                    Console.WriteLine("Student Module Details");
                    _studentModulesHttpReq.GetStudentModulesByStudentIdUI2(studentId);                    
                    _programmeSummaryHttpReq.GetProgrammeSummaryByStudentIdUI2(studentId);
                    NextActionRequest();
                    break;
                }
                Console.WriteLine("Invalid entry, check your entry!");
            }
        }

        public void CreateNewStudentInputUI()
        {
            Console.Clear();
            topDisplay.Header();
            Console.WriteLine("Create New Student Record:\n");
            Console.WriteLine("Kindly Input Student's details:");
            string firstName;
            string lastName;
            string yearOfStudy;
            string DegProgrammeId;

            while (true)
            {
                Console.WriteLine("Enter First Name: ");
                firstName = Console.ReadLine().ToUpper().Trim();                
                if (_inputValidator.ValidateOnlyLetter(firstName))
                {
                    break;
                }
                Console.WriteLine("Invalid input, avoid entry other than alphabets");
            }
            while (true)
            {
                Console.WriteLine("Enter Last Name: ");
                lastName = Console.ReadLine().ToUpper().Trim();
                if (_inputValidator.ValidateOnlyLetter(lastName))
                {
                    break;
                }
                Console.WriteLine("Invalid input, avoid entry other than alphabets");
            }
            while (true)
            {
                Console.WriteLine("Enter Year of Study: ");
                yearOfStudy = Console.ReadLine();
                if (_inputValidator.ValidateOnlyDigit(yearOfStudy))
                {
                    break;
                }
                Console.WriteLine("Invalid input, avoid entry other than alphabets");
            }

            while (true)
            {
                Console.WriteLine("Degree Programmes list, choose equivalent ID as required");
                _degreeProgrammeHttpReq.GetAllDegreeProgrammeInputReq();
                Console.WriteLine("Enter Degree Programme Id: ");
                DegProgrammeId = Console.ReadLine().Trim().ToUpper();                
                var check = _degreeProgrammeHttpReq.DegreeProgrammeByDegProgIdSearch(DegProgrammeId)
                             .Any(x => x.DegreeProgrammeId == DegProgrammeId);

                if (_inputValidator.ValidateNumberAndLetter(DegProgrammeId) && check)
                {
                    string degProgrammeId;
                    string progName;
                    int duration;
                    foreach (var x in _degreeProgrammeHttpReq.DegreeProgrammeByDegProgIdSearch(DegProgrammeId))
                    {
                        degProgrammeId = x.DegreeProgrammeId;
                        progName = x.DegreeProgrammeTitle;
                        duration = x.DegreeProgrammeDuration;
                        string choice;
                        while (true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Confirm your entry! type SAV to SAVE, MEN to Cancel, XX to Exit");
                            var table = new ConsoleTable("First Name", "Last Name", "Programme Id", "Programme choice", "Duration", "Year of study");
                            table.AddRow(firstName, lastName, degProgrammeId, progName, duration, yearOfStudy);
                            Console.WriteLine("Enter your choice:");
                            choice = Console.ReadLine().Trim().ToUpper();
                            if (choice == "SAV")
                            {
                                var newStudent = new StudentInformationViewModel()
                                {
                                    FirstName = firstName,
                                    LastName = lastName,
                                    DegreeProgrammeId = degProgrammeId,
                                    DegreeProgrammeDuration = duration,
                                    DegreeProgrammeTitle = progName,
                                    YearOfStudy = yearOfStudy,
                                    FullName = firstName + " " + lastName
                                };
                                _studentInformationHttpReq.POSTCreateStudentInformationUI(newStudent);
                                Console.WriteLine("registered!");
                                break;
                            }
                            else if (choice == "MEN")
                            {
                                StartUI();
                            }
                            else if (choice == "XX")
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                    break;
                }
                Console.WriteLine("Invalid input, enter correct Programme ID");
            }
        }            
                      
        public void NextActionRequest()
        {
            string choice;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; 
                Console.WriteLine("Please select your next action below:");
                Console.ResetColor();
                Console.WriteLine("\n Type: \n ->  MEN to go to Home Menu \n ->  XX to Exit");
                Console.WriteLine("Enter your choice:");
                choice = Console.ReadLine().ToUpper().Trim();
                if (choice == "MEN")
                {
                    StartUI();
                }
                else if (choice == "XX")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
            }
        }

    }
}
