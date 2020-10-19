using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static bool PatternValidation(String input, String pattern)
        {
            Regex re = new Regex(pattern);
            return re.IsMatch(input);
        }


        public static String validation(String pattern)
        {
            String inputString = Console.ReadLine();

            while (!PatternValidation(inputString, pattern))
            {
                Console.WriteLine(inputString + " is invalid!\nEnter again!!");
                inputString = Console.ReadLine();
            }
            Console.WriteLine(inputString + " is Valid\n");

            return inputString;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");

            User user = new User();

            // to validate first name

            Console.WriteLine("Enter the First Name(First letter should be capital)");

            String firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
            user.FirstName= validation(firstNamePattern);

            Console.WriteLine("Enter the Last Name(First letter should be capital)");

            String lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
            user.LastName = validation(lastNamePattern);


            Console.WriteLine("Enter the Email");

            String emailPattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.[a-z]{2,}(/.[a-z]{2,})?$";
            user.EmailId = validation(emailPattern);


            Console.WriteLine("Enter the phone Number");

            String phonePattern = "^[+][0-9]{1,3}[\\s][0-9]{10}$";
            user.PhoneNumber = validation(phonePattern);


            Console.WriteLine("Enter the Password");

            String passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            user.Password = validation(passwordPattern);

            Console.WriteLine($"User Registation of User: {user.FirstName} completed");



        }
    }
}