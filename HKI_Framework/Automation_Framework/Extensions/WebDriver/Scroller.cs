using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;


namespace Automation_Framework.Extensions.WebDriver
{
    /// <summary>
    /// A scroll extension class for web
    /// </summary>
    public static class Scroller
    {
        /// <summary>
        /// Excutes JavaScript to scroll a selected scrollbar horizontally
        /// </summary>
        /// <param name="driver">The driver used in the test</param>
        /// <param name="element">Name of the defined scrollbar in the Page Object </param>
        /// <param name="moveLength">Units of how much scroll there should be, use negative integer to scroll to the right</param>
        public static void GetElementAndScrollHorizontally(this IWebDriver driver, string element, int moveLength)
        {
            var js = driver as IJavaScriptExecutor;
            js.ExecuteScript($"document.querySelector({element}).scrollLeft = {moveLength}");
        }

        /// <summary>
        /// Excutes JavaScript to scroll a selected scrollbar vertically
        /// </summary>
        /// <param name="driver">The driver used in the test</param>
        /// <param name="element">Name of the defined scrollbar in the Page Object </param>
        /// <param name="moveLength">Units of how much scroll there should be, use negative integer to scroll down</param>
        public static void GetElementAndScrollVertically(this IWebDriver driver, string element, int moveLength)
        {
            var js = driver as IJavaScriptExecutor;
            js.ExecuteScript($"document.querySelector({element}).scrollTop = {moveLength}");
        }

       
    }
}