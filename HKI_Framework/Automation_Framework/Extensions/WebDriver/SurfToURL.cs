using System;
using Automation_Framework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Automation_Framework.Extensions.WebDriver
{
    /// <summary>
    /// An url navigation extension class for web
    /// </summary>
    public static class SurfToURL
    {
        /// <summary>
        /// Navigates to an URI url
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="url">The url in Uri form to which should be navigated to</param>
        public static void OpenLink(this IWebDriver driver, Uri url)
        {
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Navigates to a string url
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="url">The url in string form to which should be navigated to</param>
        public static void OpenLink(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Opens a link in a new tab
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="element">The element containing the link</param>
        public static void OpenLinkInNewTab(this IWebDriver driver, IWebElement element)
        {
            new Actions(driver).KeyDown(Keys.Control).MoveToElement(element).Click().Perform();
            Log.Info("Opened link in a new tab");
        }
    }
}
