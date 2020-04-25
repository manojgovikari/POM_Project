//Home.cs and all other page map classes update in the same way
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using POMProject.PageAssembly;
using ReportingLibrary;
using SeleniumExtras.PageObjects;
using SeleniumHelperLibrary;
using WaitHelpers = SeleniumExtras.WaitHelpers;

namespace POMProject.PageObjects
{
    public class CompanyPage
    {
        // protected ExtentReportsHelper extent;

        //[FindsBy(How = How.Id, Using = "Company")]
        //public IWebElement txtCompany;

        //[FindsBy(How = How.ClassName, Using = "ux-btn-default-action")]
        //public IWebElement btnContinuetoSignIn;


        //public CompanyPage()
        //{
        //    driver = null;
        //    extentReportsHelper = null;
        //}
        IWebDriver driver;
        public IWebElement txtCompany;

        protected ExtentReportsHelper extent;

        public CompanyPage(IWebDriver webDriver)
         {
            driver = webDriver;
            txtCompany = driver.FindElement(By.Id("Company"));
       
        }
       // private IWebDriver driver;
       // private ExtentReportsHelper extentReportsHelper;



        //public CompanyPage()
        //{
        //    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    txtCompany = driver.FindElement(By.Id("Company"));
        //    btnContinuetoSignIn = driver.FindElement(By.ClassName("ux-btn-default-action"));
        //}

        public void EnterCompany(string text)
        {
            txtCompany.SendKeys("optum");
            //WebElementExtension.SetPass(reportsHelper);


            //ExtentReportsHelper extentReportsHelper = new ExtentReportsHelper();
            //extentReportsHelper.SetStepStatusPass("Company entered");
            //WebElementExtension.SendKeysWrapper(txtCompany, extentReportsHelper, "optum", "Company");

            //Assert.IsTrue(driver.ValidatePageTitle(extentReportsHelper, "nopCommerce demo store"));


            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //txtCompany.SendKeys(text);
            //btnContinuetoSignIn.Click();

            //browser.StepPassed("Entered company as -"+text);

        }
    }
}
