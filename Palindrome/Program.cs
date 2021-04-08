using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                Console.Write("Please enter a word to check if it is a palindrome: ");
                string str = Console.ReadLine();

                //clean the string before inputing in palindrome checker
                string FormattedString = FormatString(str);

                bool IsPalindorme = PalindromeChecker(FormattedString);

                Console.WriteLine(IsPalindorme);

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
            }
        }

        static bool PalindromeChecker(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            string newStr = string.Join("", arr);
            
            return newStr == str;
        }

        //incase user puts in a string with spaces or upper case letters
        static string FormatString(string str)
        {
            string newStr = str.Replace(" ", "").ToLower();
            return newStr;
        }
    }
}

