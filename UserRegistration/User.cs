using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UserRegistration
{
    
    class User
    {

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
         //string name;

        public string FirstName { get; set; }


        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        
        public string EmailId { get; set; }


        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>

        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        
        public string Password{ get; set; }

        public User()
        {

        }

        /// <summary>
        /// Gets the user's details.
        /// </summary>
        public void GetUserDetails()
        {
            Console.WriteLine("\nRegistration successful\n");

            Console.WriteLine("First Name : " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Email address :" + EmailId);
            Console.WriteLine("phone number :" + PhoneNumber);
            Console.WriteLine("passord :" + Password);
        }
    }
}