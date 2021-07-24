using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        public User user;

        [TestInitialize]
        public void SetUp()
        {
            user = new User();
        }
        /// <summary>
        /// Happy TestCases
        /// </summary>
        [TestMethod]
        public void FirstNameValidationShouldReturnTrue()
        {
            string firstName = "Ajith";
            bool result = user.ValidateFirstName(firstName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameValidationShouldReturnTrue()
        {
            string lastName = "Kumar";
            bool result = user.ValidateLastName(lastName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailValidationShouldReturnTrue()
        {
            string email = "Ajith43@gmail.com";
            bool result = user.ValidateEmail(email);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnTrue()
        {
            string mobileNumber = "91 9995559955";
            bool result = user.ValidateMobileNumber(mobileNumber);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationShouldReturnTrue()
        {
            string password = "Ajith@123";
            bool result = user.ValidatePassword(password);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Sad Test Cases
        /// </summary>
        [TestMethod]
        public void FirstNameValidationShouldReturnFalse()
        {
            string firstName = "ajith";
            bool result = user.ValidateFirstName(firstName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameValidationShouldReturnFalse()
        {
            string lastName = "kumar";
            bool result = user.ValidateLastName(lastName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailValidationShouldReturnFalse()
        {
            string email = "ajay@com";
            bool result = user.ValidateEmail(email);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnFalse()
        {
            string mobileNumber = "91 0995559955";
            bool result = user.ValidateMobileNumber(mobileNumber);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationShouldReturnFalse()
        {
            string password = "Ajay123";
            bool result = user.ValidatePassword(password);
            Assert.IsTrue(result);
        }
    }
}
