using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        // Pattern Validation 
        public static bool PatternValidation(String input, String pattern)
        {
            Regex re = new Regex(pattern);
            return re.IsMatch(input);
        }

        // validation method to pattern validation
        public static String validation(String pattern)
        {
            String inputString = Console.ReadLine();

            while (!PatternValidation(inputString, pattern))
            {
                Console.WriteLine(inputString+ " is invalid!\nEnter again!!");
                inputString = Console.ReadLine();
            }
            Console.WriteLine(inputString + " is Valid\n");

            return inputString;

        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");

            // to validate first name

            Console.WriteLine("Enter the First Name(First letter should be capital)");
            
            String firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
            String firstName = validation(firstNamePattern);

            Console.WriteLine("Enter the Last Name(First letter should be capital)");

            // to validate Last name
            String lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
            String lastName = validation(lastNamePattern);

            // to validate Email 
            Console.WriteLine("Enter the Email");

            String emailPattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";
            String email = validation(emailPattern);

            // to validate Phone number
            Console.WriteLine("Enter the phone Number");

            String phonePattern = "^[+][0-9]{1,3}[\\s][0-9]{10}$";
            String phoneNo = validation(phonePattern);

            // to validate Password
            Console.WriteLine("Enter the Password");

            String passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            String password = validation(passwordPattern);

        }
    }
}
