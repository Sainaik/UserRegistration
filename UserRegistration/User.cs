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

        [StringLength(25, MinimumLength = 3, ErrorMessage = "{0} field is required")]
        [RegularExpression("^[A-Z]{1}[a-z]{2,25}$", ErrorMessage = "Invalid FirstName entered")]
        public string FirstName { get; set; }


        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [StringLength(25, MinimumLength = 3, ErrorMessage = "{0} field is required")]
        [RegularExpression("(^[A-Z]{1}[a-z]{2,25}$)", ErrorMessage = "Invalid LastName entered")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        
        [StringLength(25, MinimumLength = 5, ErrorMessage = "{0} field is required")]
        [RegularExpression(@"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$", ErrorMessage = "Invalid Emailid entered")]
        public string EmailId { get; set; }


        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>

        [StringLength(25, MinimumLength = 13, ErrorMessage = "{0} field is required")]
        [RegularExpression("^[+][0-9]{1,3}[\\s][0-9]{10}$", ErrorMessage = "Invalid PhoneNumber entered")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        
        [StringLength(15, MinimumLength = 8, ErrorMessage = "{0} field is required")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Invalid Password entered")]
        public string Password{ get; set; }

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