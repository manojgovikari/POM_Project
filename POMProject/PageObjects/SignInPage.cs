//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace POMProject.PageObjects
//{
//    class SignInPage
//    {
//        public SignInPage()
//        {
//            driver = null;
//        }

//        public SignInPage(IWebDriver driver)
//        {
//            this.driver = driver;
//        }

//        //Driver
//        private IWebDriver driver;
//        private WebDriverWait wait;
//        readonly private int defaultWaitTime = 3;

//        //Locators
//        [FindsBy(How = How.Id, Using = "UserName")]
//        private IWebElement Userid;



//        //Actions
//        public void eFRLogin(string userid)
//        {
//            Userid.SendKeys(userid);
//        }
//    }
//}
