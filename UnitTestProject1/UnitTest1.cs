using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using System.Security.Cryptography.X509Certificates;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "CMD";
            string a = "A_" + s;
            Assert.AreEqual(a, StClass.AddA(s));
        }       
    }
}

