using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentMe.Util;

namespace RentMe.Tests
{
    [TestClass]
    public class UnitTestSecurity
    {
        [TestMethod]
        public void TestEncrypt()
        {
            var encryptedPassword = Security.encrypt("tyer865!");
        }
    }
}
