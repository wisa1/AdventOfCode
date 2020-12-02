using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Day2
{
    class PasswordPolicy
    {
        public int MinimumAllowed{ get; set; }
        public int MaximumAllowed { get; set; }
        public char Character { set; get; }
        public string Password { set; get; }
        public int PasswordCharacterCount { set; get; } = 0;
        
        // Challenge 1 
        public bool IsValid()
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (Password[i] == Character)
                    PasswordCharacterCount++;
            }

            if (PasswordCharacterCount >= MinimumAllowed && PasswordCharacterCount <= MaximumAllowed)
                return true;
            return false;
        }

        // Challenge 2
        public bool IsValid2()
        {
            char first  = Password[MinimumAllowed - 1];
            char second = Password[MaximumAllowed - 1];

            if (first == Character ^ second == Character)
                return true;
            return false;
        }
    }    
}
