
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using NLog;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.WebDriverExtensions
{

    public static class WebDriverExtension
    {
      

        // Common methods or Re-usable methods for page

        /// <summary>
        /// Enter the text in textboxes / Edit boxes
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebDriver driver, By locator, string value, string name)
        {
            try
            {
                IWebElement ele = driver.FindElement(locator);
                if (ele.Displayed && ele.Enabled)
                {
                    
                    ele.Clear();
                    ele.SendKeys(value);
                }
            }
            catch (Exception e)
            {
                
                throw;
            }

        }

        /// <summary>
        /// Click the buttton, radio button, Checkboxes
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        public static void Click(this IWebDriver driver, By locator, string name)
        {
            try
            {
                IWebElement ele = driver.FindElement(locator);
                if (ele.Displayed && ele.Enabled)
                {
                    
                    ele.Click();
                }
            }
            catch (Exception e)
            {
                
                throw;
            }



        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator, string name)
        {
            IWebElement ele = driver.FindElement(locator);
            if (ele.Displayed)
            {
                
                return true;
            }
            return true;
        }

        /// <summary>
        /// Get text of WebElement
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static string getText(this IWebDriver driver, By locator)
        {

            IWebElement ele = driver.FindElement(locator);
            var text = "";
            if (ele.Displayed)
            {
                text = ele.Text;
            }
            return text;
        }

        /// <summary>
        /// Element Text displayed
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool getTextWithValueDisplayed(this IWebDriver driver, string value)
        {

            IWebElement ele = driver.FindElement(By.XPath("//*[text()='" + value + "']"));
            if (ele.Displayed)
            {
                return true;
            }

            return true;
        }

        public static void IsAlertPresent()
        {

        }

        public static void SelectByVisibleTextFromDropDown()
        {

        }
    }
}
