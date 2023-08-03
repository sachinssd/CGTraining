using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using SeleniumUITest.WebDriverExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.Pages
{
    public class HomePage : BaseClass

    {


        // Instance of Webdriver

        public static new IWebDriver driver;
        // Create a constructor

        public HomePage(IWebDriver driver)
        {
            HomePage.driver = driver;
        }

        public String getTitle()
        {
            return driver.Title;
        }

        /* Page Objects  - for webelements
         */

        public readonly By registerlink = By.ClassName("ico-register");
        public readonly By loginlink = By.ClassName("ico-login");

        // Name of the web Elements

        private static string registerlinknm = "Register Link";
        private static string loginlinknm = "Login link";
        /// page Methods
        /// 
        public void ClickRegisterLink()
        {
            driver.Click(registerlink, registerlinknm);
        }

        public void ClickLoginLink()
        {
            driver.Click(loginlink, loginlinknm);
        }

    }
}
