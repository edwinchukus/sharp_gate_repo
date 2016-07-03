using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ThirdSeleniumProject.seleniumConcept
{
    [TestClass]
  public  class OnlineShopping
    {
        private IWebDriver _driver;
        [TestInitialize]
        public void precondition()
        {
           _driver= new ChromeDriver(); 
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.tesco.com");
            IList<Cookie> cocky = _driver.Manage().Cookies.AllCookies;
           
            {
                
            }
        }
        [TestCleanup]
        public void postcondition()
        {
           _driver.Quit();
        }
        [TestMethod, TestCategory("UAT")]
        public void TestOnlineAccount()
        {
            
        }
    }
}
