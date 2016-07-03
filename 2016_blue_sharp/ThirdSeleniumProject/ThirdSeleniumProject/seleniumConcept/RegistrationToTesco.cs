using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ThirdSeleniumProject.seleniumConcept
{ [TestClass]
    public class RegistrationToTesco
{
    private IWebDriver _driver;
    [TestMethod]
    
    

    [TestInitialize]
        public void Precondition()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            
        }
        [TestCleanup]
        public void Postcondition()
        {
            _driver.Close();
        }
        public void TestCustomerAccount()
    {
        
    }
    }
}
