using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {

        public static bool phnoValidation(String phno)
        {
            String patternPN = "^[+][0-9]{1,3}[\\s][0-9]{10}$";

            Regex re = new Regex(patternPN);
            return re.IsMatch(phno);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");

            // to validate first name

            Console.WriteLine("Enter the Phone Number");
            String PhoneNumber = Console.ReadLine();

            if (phnoValidation(PhoneNumber))
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number");
            }

           

            
        }
    }
}
