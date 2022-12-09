using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAdministrationSystem.UtilitiesUI
{
    public class InputValidator
    {
        public bool ValidateOnlyDigit(string input)
        {
            int Count = 0;
            if (input == null)
            {
                return false;
            }

            foreach (var x in input)
            {
                if (!Char.IsDigit(x))
                {
                    Count++;
                }
            }
            if (Count > 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public bool ValidateOnlyLetter(string input)
        {
            int Count = 0;
            if (input == null)
            { 
                return false;
            }

            foreach (var x in input)
            {
                if (!Char.IsLetter(x))
                {
                    Count++;
                }
            }
            if (Count > 0)
            {
                return false;
            }
            else { return true; }
        }

       

        public bool ValidateNumberAndLetter(string input)
        {
            int Count = 0;
            if (input == null) 
            { 
                return false;
            }

            foreach (var x in input)
            {
                if (!Char.IsLetterOrDigit(x))
                {
                    Count++;
                }
            }
            if (Count > 0)
            {
                return false;
            }
            else
            { 
                return true; 
            }
        }
    }
}
