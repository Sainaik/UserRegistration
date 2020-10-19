using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UnitTestForUserRegistration
{
    [TestClass]
    
    public class TestUserDetails
    {
        //UC 10 TC 10.1 Valid Names
        [TestMethod]
        [DataRow("Sai",true)]
        [DataRow("Naik", true)]
        [DataRow("Kumar", true)]
        public void TestPatternValidation_GivenValidName_returnTrue(string inputFirstName, bool expected)
        {
            string FirstNamePattern = @"^[A-Z][a-z ]{2,}$";
            bool actual = Program.PatternValidation(inputFirstName,FirstNamePattern);

            Assert.AreEqual(expected, actual);

        }

        //UC 12 TC 12.1 Invalid Names UserExcepition
        [TestMethod]
        [DataRow("sai", "Invalid user Detail")]
        [DataRow("Na", "Invalid user Detail")]
        [DataRow("12Asdf", "Invalid user Detail")]
        public void TestPatternValidation_GivenInValidName_ThowsUserException(string inputFirstName,string expected)
        {
            try{
                string FirstNamePattern = @"^[A-Z][a-z ]{2,}$";
                Program.PatternValidation(inputFirstName, FirstNamePattern);
            }
            catch (InvalidUserDetailException e)
            {

                Assert.AreEqual(expected, e.Message);
            }

        }

        //UC 10 TC 10.2 Valid EmailIDs
        [TestMethod]
        [DataRow("sai@gmail.com", true)]
        [DataRow("sai.123@gmail.com", true)]
        [DataRow("sai.123naik@gmail.com.co", true)]
        public void TestPatternValidation_GivenValidEmailId_returnTrue(string EmailId, bool expected)
        {
            string emailIdPattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";
            bool actual = Program.PatternValidation(EmailId, emailIdPattern);

            Assert.AreEqual(expected, actual);

        }

        //UC 10 TC 12.2 Invalid EmailIDs
        [TestMethod]
        [DataRow("Sai@gmail.com", "Invalid user Detail")]
        [DataRow("Na", "Invalid user Detail")]
        [DataRow("saigmail.com", "Invalid user Detail")]
        [DataRow("sai@gmail.com.com", "Invalid user Detail")]
        public void TestPatternValidation_GivenInValidEmailId_ThowsUserException(string EmailId, string expected)
        {
            try
            {
                string emailIdPattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.[a-z]{2,}(/.[a-z]{2,})?$";
                Program.PatternValidation(EmailId, emailIdPattern);
            }
            catch (InvalidUserDetailException e)
            {

                Assert.AreEqual(expected, e.Message);
            }
        }

        //UC 10 TC 10.3 Valid Phone Numbers
        [TestMethod]
        [DataRow("+919087654321", true)]
        [DataRow("+919012345678", true)]
        [DataRow("+91 9087654321", true)]
        [DataRow("+91 9012345678", true)]
        public void TestPatternValidation_GivenValidPhoneNumber_returnTrue(string phoneNumber, bool expected)
        {
            string phonePattern = "^[+][1-9]{1,3}(\\s)?[0-9]{10}$";
            bool actual = Program.PatternValidation(phoneNumber, phonePattern);

            Assert.AreEqual(expected, actual);

        }

        //UC 12 TC 12.3 Invalid Phone Numbers
        [TestMethod]
        [DataRow("9087654321", "Invalid user Detail")]
        [DataRow("91 9012345678", "Invalid user Detail")]
        [DataRow("4321", "Invalid user Detail")]
        [DataRow("+91A B9012345678", "Invalid user Detail")]
        public void TestPatternValidation_GivenInValidPhoneNumber_ThowsUserException(string phoneNumber, string expected)
        {
            try
            {
                string phonePattern = "^[+][0-9]{1,3}(\\s)?[0-9]{10}$";
                bool actual = Program.PatternValidation(phoneNumber, phonePattern);
            }
            catch (InvalidUserDetailException e)
            {

                Assert.AreEqual(expected, e.Message);
            }
        }

        //UC 10 TC 10.4 valid Phone Numbers
        [TestMethod]
        [DataRow("sai@123A", true)]
        [DataRow("sai*123C", true)]
        [DataRow("SaiABC-123", true)]
        public void TestPatternValidation_GivenValidPassword_returnTrue(string password, bool expected)
        {
            string passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            bool actual = Program.PatternValidation(password, passwordPattern);

            Assert.AreEqual(expected, actual);

        }

        //UC 12 TC 12.4 Invalid Passwords
        [TestMethod]
        [DataRow("sai@123", "Invalid user Detail")]
        [DataRow("sai123C", "Invalid user Detail")]
        [DataRow("SaiABC.,123", "Invalid user Detail")]
        public void TestPatternValidation_GivenInValidPassword_ThowsUserException(string password, string expected)
        {
            try
            {
                string passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
                bool actual = Program.PatternValidation(password, passwordPattern);
            }
            catch (InvalidUserDetailException e)
            {

                Assert.AreEqual(expected, e.Message);
            }
        }



        //UC 11 Multiple Entry Email Ids are invalid
        [TestMethod]
        [DataRow("sai@gmail.com sai.123@gmail.com", "Invalid user Detail")]
        
        public void TestPatternValidation_GivenMultipleEntrymailId_ThowsUserException(string EmailId, string expected)
        {
            try
            {
                string emailIdPattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";
                bool actual = Program.PatternValidation(EmailId, emailIdPattern);
            }
            catch (InvalidUserDetailException e)
            {

                Assert.AreEqual(expected, e.Message);
            }
        }





    }
}
