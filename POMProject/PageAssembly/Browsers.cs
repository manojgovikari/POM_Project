//Browsers.cs
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using ReportingLibrary;
using System.Configuration;

namespace POMProject.PageAssembly
{
    public class Browsers
    {
        public Browsers(ExtentReportsHelper reportsHelper)
        {
            extentReportsHelper = reportsHelper;
        }
        private static IWebDriver webDriver;
        private string baseURL;
        private string browser;
        private ExtentReportsHelper extentReportsHelper;
        public void Init()
        {
            baseURL = ConfigurationManager.AppSettings["url"];
            browser = ConfigurationManager.AppSettings["browser"];
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }
            extentReportsHelper.SetStepStatusPass("Browser started.");
            webDriver.Manage().Window.Maximize();
            extentReportsHelper.SetStepStatusPass("Browser maximized.");
            Goto(baseURL);

        }
        public string Title
        {
            get { return webDriver.Title; }
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public void Goto(string url)
        {
            webDriver.Url = url;
            extentReportsHelper.SetStepStatusPass($"Browser navigated to the url [{url}].");
        }
        public void Close()
        {
            webDriver.Quit();
            extentReportsHelper.SetStepStatusPass($"Browser closed.");
        }

        public void StepPassed(string desc)
        {
            extentReportsHelper.SetStepStatusPass(desc);
        }

        public void StepFailed(string desc)
        {
            extentReportsHelper.SetTestStatusFail(desc);
        }
    }
}
