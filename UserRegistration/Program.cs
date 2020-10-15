using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Reflection;

namespace UserRegistration
{
    class Program
    { 

        static ValidationContext context;
        static List<ValidationResult> result = new List<ValidationResult>();
        static bool isValid;

        static void Validate(User userObject, string fieldName)
        {

            string tempFieldName = fieldName;

            fieldName = "set_" + fieldName;

            Type userType = Type.GetType("UserRegistration.User");

            MethodInfo method = userType.GetMethod(fieldName);

            string input;  
           
            while (true)
            {
                //getting input from user
                input = Console.ReadLine();

                //method.Invoke()
                method.Invoke(userObject, new object[]{ input });
                

                isValid = Validator.TryValidateObject(userObject, context, result, true);

                //valdating the input
                if (!isValid)
                {
                    Console.WriteLine(result[result.Count - 1].ErrorMessage);
                    Console.WriteLine("Please Enter your "+ tempFieldName +" Again!!");
                }
                else
                {
                    break;
                }
            }

        }
        static void Main(string[] args)
        {

            User userObject = new User();
            context = new ValidationContext(userObject, null, null);


            Console.WriteLine("Enter your First Name");
            Validate(userObject, "FirstName");
            

            Console.WriteLine("\nEnter your Last Name");
            Validate(userObject, "LastName");
            

            Console.WriteLine("\nEnter your Email");
            Validate(userObject, "EmailId");

            
            Console.WriteLine("\nEnter your Phone Number");
            Validate(userObject, "PhoneNumber");

            Console.WriteLine("\nEnter your Password");
            Validate(userObject, "Password");

            userObject.GetUserDetails();
            
        }
    }
}