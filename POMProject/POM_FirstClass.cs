using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMProject.PageObjects;
using ReportingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMProject
{
    [TestFixture]
    public class POM_FirstClass : TestBase
    {
        private static IWebDriver driver;

        protected ExtentReportsHelper extent;

        [SetUp]
        public void SetUp()
        {
            browser.Init();
            driver = browser.getDriver;
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://efrplatformqa.optum.com/UserProvisioningLandingPage/");
        }


        [Test]
        public void eFRLogin()
        {

            CompanyPage cmp = new CompanyPage(driver);
            cmp.EnterCompany("optum");
            browser.StepPassed("Entered Company Name as -optum");

        }

        [Test]
        public void eFRLogin_1()
        {
            CompanyPage cmp = new CompanyPage(driver);
            cmp.EnterCompany("optum");

        }

        
        [TearDown]
        public void TearDown()
        {
           browser.Close();
        }
    }
}
