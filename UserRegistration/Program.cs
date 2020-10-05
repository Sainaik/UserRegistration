using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {

        public static bool NameValidation(String firstName)
        {
            String patternFN = "^[A-Z]{1}[a-z]{2,}$";

            Regex re = new Regex(patternFN);
            return re.IsMatch(firstName);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");

            // to validate first name

            Console.WriteLine("Enter the First Name");
            String firstName = Console.ReadLine();

            if (NameValidation(firstName))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }

        }
    }
}
