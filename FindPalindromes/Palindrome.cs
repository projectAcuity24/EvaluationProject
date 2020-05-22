using System;
using System.Collections.Generic;

namespace FindPalindromes
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int applicationState = 0;


            while (applicationState != 2)
            {
                Console.WriteLine("............PALINDROME FINDER.............");
                Console.WriteLine("1. Enter 1 to Start/ Continue");
                Console.WriteLine("2. Enter 2 to Exit");

                try
                {
                    applicationState = Convert.ToInt32(Console.ReadLine());
                    if (applicationState == 2)
                        Environment.Exit(0);

                    else if (applicationState == 1)
                    {
                        Console.WriteLine("Please enter List of Strings (NOTE: Enter a space in between 2  strings) ");
                        Console.WriteLine("Eg: string1 string2 string3 ");
                        string inputString = Console.ReadLine();

                        string[] inputs = inputString.Split(' ');

                        FindPalindromes(inputs);
                    }
                    else
                    {
                        Console.WriteLine("Option not present");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Exception occured : ", ex);
                }
            }

        }

        private static void FindPalindromes(string[] inputList)
        {
            bool isPalindrome = false;
            foreach (var input in inputList)
            {
                char[] temp = input.ToCharArray();
                Array.Reverse(temp);
                string reversed = new string(temp);

                if (input.Equals(reversed,StringComparison.CurrentCultureIgnoreCase))
                {
                    isPalindrome = true;
                    Console.WriteLine("String " + input + " is a PALINDROME");
                }


            }
            if (!isPalindrome)
            {
                Console.WriteLine("PALINDROME NOT PRESENT");
            }

        }
    }
}
