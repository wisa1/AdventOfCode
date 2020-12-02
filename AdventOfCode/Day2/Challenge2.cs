using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AdventOfCode.Day2
{
    class Challenge2
    {
        public static void Day2Challenge2()
        {
            List<PasswordPolicy> passwordPolicies = InitTestData();
            int validPasswordCount = passwordPolicies.Where(x => x.IsValid2()).ToList().Count;
            Console.WriteLine(validPasswordCount);
        }

        private static List<PasswordPolicy> InitTestData()
        {
            List<PasswordPolicy> policies = new List<PasswordPolicy>();
            string fileContent = File.ReadAllText(@"C:\Users\Wisa\source\repos\AdventDay1\AdventOfCode\Day2\Day1Input.txt");

            var arr = fileContent.Split('\n');
            for (int i = 0; i < arr.Length; i++)
            {
                string MinMax = arr[i].Split(":")[0];
                int Min = Convert.ToInt32(MinMax.Split("-")[0]);
                int Max = Convert.ToInt32(MinMax.Split("-")[1].Split(" ")[0]);
                char Character = Convert.ToChar(MinMax.Split("-")[1].Split(" ")[1]);
                string Password = arr[i].Split(":")[1].Trim();

                policies.Add(new PasswordPolicy
                {
                    MinimumAllowed = Min,
                    MaximumAllowed = Max,
                    Character = Character,
                    Password = Password
                });
            }
            return policies;
        }
    }
}
