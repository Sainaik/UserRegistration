using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration 
{
    public class InvalidUserDetailException : Exception
    {
        public InvalidUserDetailException()
        {
        }

        public InvalidUserDetailException(string message):base(message)
        {

        }
    }
}
