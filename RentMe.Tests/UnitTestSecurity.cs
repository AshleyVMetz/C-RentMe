using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentMe.Util;

namespace RentMe.Tests
{
    /// <summary>
    /// Test Class for Security
    /// </summary>
    [TestClass]
    public class UnitTestSecurity
    {
        /// <summary>
        /// Tests for encrypting password - note user name after User(ex:sSmith1234)
        /// </summary>
        [TestMethod]
        public void TestEncryptUsersSmith1234()
        {
            var encryptedPassword = Security.encrypt("tyer865!");
        }

        [TestMethod]
        public void TestEncryptUserSClark987()
        {
            var encryptedPassword = Security.encrypt("kjdslf!!8");
        }

        [TestMethod]
        public void TestEncryptUservhartup00()
        {
            var encryptedPassword = Security.encrypt("Y182TqCp");
        }

        [TestMethod]
        public void TestEncryptUserowilbor1()
        {
            var encryptedPassword = Security.encrypt("dklafjiweuhfwekj78");
        }

        [TestMethod]
        public void TestEncryptUserrconnaughton2()
        {
            var encryptedPassword = Security.encrypt("sdklfjsdlkj87");
        }

        [TestMethod]
        public void TestEncryptUserKTrev01()
        {
            var encryptedPassword = Security.encrypt("kdjsflk897!!");
        }

        [TestMethod]
        public void TestEncryptUserosteynor5()
        {
            var encryptedPassword = Security.encrypt("kdj8DDK");
        }

        [TestMethod]
        public void TestEncryptUsermDucarne9()
        {
            var encryptedPassword = Security.encrypt("dkjf8YYY");
        }

        [TestMethod]
        public void TestEncryptUsernnortega()
        {
            var encryptedPassword = Security.encrypt("YJJkles8");
        }

        [TestMethod]
        public void TestEncryptUserjDoe()
        {
            var encryptedPassword = Security.encrypt("admin");
        }


    }
}
