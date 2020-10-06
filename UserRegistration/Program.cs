using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {

        public static bool EmailValidation(String email)
        {

            //String pattern = @"^([a-z][a-z0-9.+_-]*@([a-z0-9]([a-z0-9-]*[a-z0-9])?\.)+[a-z0-9]([a-z0-9-]*[a-z0-9])?)$";

            //String pattern = @"^[a-z]+[-+*.]?[0-9a-z]*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";

            String pattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";

            Regex r = new Regex(pattern);

            return r.IsMatch(email);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");

            // to validate first name

            
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

            
        }
    }
}
