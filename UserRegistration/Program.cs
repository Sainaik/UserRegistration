using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {

        public static bool passwordValidation(String password)
        {
            String patternPassword = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

            Regex re = new Regex(patternPassword);
            return re.IsMatch(password);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");

            // to validate first name

            Console.WriteLine("Enter the Password");
            String password = Console.ReadLine();

            if (passwordValidation(password))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }

           

        }
    }
}
