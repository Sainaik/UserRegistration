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

        //UC 10 TC 10.2 Invalid Names
        [TestMethod]
        [DataRow("sai", false)]
        [DataRow("Na", false)]
        [DataRow("12Asdf", false)]
        public void TestPatternValidation_GivenInValidName_returnFalse(string inputFirstName, bool expected)
        {
            string FirstNamePattern = @"^[A-Z][a-z ]{2,}$";
            bool actual = Program.PatternValidation(inputFirstName, FirstNamePattern);

            Assert.AreEqual(expected, actual);

        }

        //UC 10 TC 10.3 Valid EmailIDs
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

        //UC 10 TC 10.4 Invalid EmailIDs
        [TestMethod]
        [DataRow("Sai@gmail.com", false)]
        [DataRow("Na", false)]
        [DataRow("saigmail.com", false)]
        [DataRow("sai@gmail.com.com", false)]
        public void TestPatternValidation_GivenInValidEmailId_returnFalse(string EmailId, bool expected)
        {
            string emailIdPattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.[a-z]{2,}(/.[a-z]{2,})?$";
            bool actual = Program.PatternValidation(EmailId, emailIdPattern );

            Assert.AreEqual(expected, actual);

        }

        //UC 10 TC 10.5 Valid Phone Numbers
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

        //UC 10 TC 10.6 Invalid Phone Numbers
        [TestMethod]
        [DataRow("9087654321", false)]
        [DataRow("91 9012345678", false)]
        [DataRow("4321", false)]
        [DataRow("+91A B9012345678", false)]
        public void TestPatternValidation_GivenInValidPhoneNumber_returnFalse(string phoneNumber, bool expected)
        {
            string phonePattern = "^[+][0-9]{1,3}(\\s)?[0-9]{10}$";
            bool actual = Program.PatternValidation(phoneNumber, phonePattern);

            Assert.AreEqual(expected, actual);

        }

        //UC 10 TC 10.7 valid Phone Numbers
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

        //UC 10 TC 10.8 Invalid Passwords
        [TestMethod]
        [DataRow("sai@123", false)]
        [DataRow("sai123C", false)]
        [DataRow("SaiABC.,123", false)]
        public void TestPatternValidation_GivenInValidPassword_returnFalse(string password, bool expected)
        {
            string passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            bool actual = Program.PatternValidation(password, passwordPattern);

            Assert.AreEqual(expected, actual);

        }



        //UC 11 Multiple Entry Email Ids are invalid
        [TestMethod]
        [DataRow("sai@gmail.com sai.123@gmail.com", false)]
        
        public void TestPatternValidation_GivenMultipleEntrymailId_returnFalse(string EmailId, bool expected)
        {
            string emailIdPattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";
            bool actual = Program.PatternValidation(EmailId, emailIdPattern);

            Assert.AreEqual(expected, actual);

        }





    }
}
