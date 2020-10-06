using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {

<<<<<<< HEAD
        public static bool EmailValidation(String email)
        {

            //String pattern = @"^([a-z][a-z0-9.+_-]*@([a-z0-9]([a-z0-9-]*[a-z0-9])?\.)+[a-z0-9]([a-z0-9-]*[a-z0-9])?)$";

            //String pattern = @"^[a-z]+[-+*.]?[0-9a-z]*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";

            String pattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";

            Regex r = new Regex(pattern);

            return r.IsMatch(email);

=======
        public static bool phnoValidation(String phno)
        {
            String patternPN = "^[+][0-9]{1,3}[\\s][0-9]{10}$";

            Regex re = new Regex(patternPN);
            return re.IsMatch(phno);
>>>>>>> UC4-PhoneNumberValidation
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");

            // to validate first name

<<<<<<< HEAD
            
            Console.WriteLine("Enter the Email");

            String email = Console.ReadLine();

            if (EmailValidation(email))
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }
=======
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

           
>>>>>>> UC4-PhoneNumberValidation

            
        }
    }
}
