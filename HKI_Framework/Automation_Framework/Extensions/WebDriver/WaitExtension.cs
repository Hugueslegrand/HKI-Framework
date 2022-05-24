using System;
using OpenQA.Selenium;
using Automation_Framework.Utilities;
using OpenQA.Selenium.Support.UI;
using Automation_Framework.Helpers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Threading;

namespace Automation_Framework.Extensions.WebDriver
{
    /// <summary>
    /// A wait extension class for web
    /// </summary>
    public static class WaitExtension
    {
        /// <summary>
        /// Waits a specified amount of seconds
        /// </summary>
        /// <param name="seconds">Amount of seconds to wait</param>
        public static void WaitSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        /// <summary>
        /// Used for the defaultimeout wait specified in appSettings
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <returns>A WebDriverWait function</returns>
        public static WebDriverWait Wait(this IWebDriver driver)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.WebDriver.DefaultTimeout));
        }

        public static void Exists(this IWebDriver  driver, By by) {

            if (driver is null) Log.Warn("The driver has not been build");
            WebDriverWait waitFunc = new WebDriverWait(driver, TimeSpan.FromSeconds(Configuration.WebDriver.DefaultTimeout));
            try
            {
                waitFunc.Until(ExpectedConditions.ElementExists(by));
            }
            catch (Exception)
            {
                Log.Warn($"failed to locate {by} within {Configuration.WebDriver.DefaultTimeout} seconds");
                throw;
            }

        }
        /// <summary>
        /// Waits until an element is clickable
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="by">Locator with OpenQA's By method which should become clickable</param>
        
        public static void WaitForClickable(this IWebDriver driver, By by)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            WebDriverWait waitFunc = new WebDriverWait(driver, TimeSpan.FromSeconds(Configuration.WebDriver.DefaultTimeout));
            try
            {
                waitFunc.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            catch (Exception)
            {
                Log.Warn($"failed to locate {by} within {Configuration.WebDriver.DefaultTimeout} seconds");
                throw;
            }
           
        }

        /// <summary>
        /// Waits until an element is clickable
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="element">Defined WebElement in the Page Object which should become clickable</param>
     
        public static void WaitForClickable(this IWebDriver driver, IWebElement element)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            WebDriverWait waitFunc = new WebDriverWait(driver, TimeSpan.FromSeconds(Configuration.WebDriver.DefaultTimeout));
            waitFunc.Until(ExpectedConditions.ElementToBeClickable(element));
        }

    }
}
