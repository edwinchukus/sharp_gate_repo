using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firstSeleniumProject.UnitTest
{
    [TestClass]
   public class LoginTest
    {  [TestInitialize]
        public void Precondition()
        {
        Console.WriteLine("this is a test condition");   
        }
        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("this is a post condition and it will fire after any test method");
        }

        [TestMethod]
        public void TestLogin()
        {
            Console.WriteLine("This is my logging in account");    
        }

        public void TestMyAccount()
        {
            Console.WriteLine("my account works well");
        }
    }
}
