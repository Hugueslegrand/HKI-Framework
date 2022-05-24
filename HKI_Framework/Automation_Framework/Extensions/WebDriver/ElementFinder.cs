using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Automation_Framework.Utilities;

namespace Automation_Framework.Extensions.WebDriver
{
    /// <summary>
    /// An element locator extension class for web
    /// </summary>
    public static class ElementFinder
    {
        /// <summary>
        /// Method used to find elements with the same locator and put them in a List
        /// </summary>
        /// <param name="driver">The web driver.</param>
        /// <param name="by">Locator with OpenQA's By method.</param>
        /// <returns>Returns a List with WebElements</returns>
        public static IList<IWebElement> FindElementAboveZero(this IWebDriver driver, By by)
        {
            try
            {
                driver.Wait().Until(x => x.FindElements(by).Count > 0);
            }
            catch (System.Exception)
            {
                Log.Warn($"Unable to find elements with locator {by}.");
                throw;
            }
            
            return driver.FindElements(by);
        }

        /// <summary>
        /// Method used to filter elements with the same class, id or path and to return the element containing the text input
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="by">Locator with OpenQA's By method</param>
        /// <param name="text">The text that has to be found</param>
        /// <returns>Returns the first element containing the input text</returns>
        public static IWebElement FindElementByText(this IWebDriver driver, By by, string text)
        {
            try
            {
                driver.Wait().Until(x => x.FindElements(by).First(y => y.Text == text));
            }
            catch (System.Exception)
            {
                Log.Warn($"Unable to find elements with locator {by} containing the text {text}.");
                throw;
            }
           
            return driver.FindElements(by).First(x => x.Text == text);
        }

        /// <summary>
        /// Method used to move to an element based on By Locator
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="by">Locator with OpenQA's By method</param>
        public static void MoveToElement(this IWebDriver driver, By by)
        {
            
            var actions = new Actions(driver);
            driver.WaitForClickable(by);
            try
            {
                actions.MoveToElement(driver.FindElement(by)).Build().Perform();
            }
            catch (System.Exception)
            {
                Log.Warn($"Unable to move to the {driver.FindElement(by)}.");
                throw;
            }
            
        }

        /// <summary>
        /// Method used to move to an element based on WebElement defined in Page Object
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="element">WebElement defined in Page Object</param>
        public static void MoveToElement(this IWebDriver driver, IWebElement element)
        {
            var actions = new Actions(driver);
            driver.WaitForClickable(element);
            try
            {
                actions.MoveToElement(element).Build().Perform();
            }
            catch (System.Exception)
            {
                Log.Warn($"Unable to move to the {element}.");
                throw;
            }
           
        }

        /// <summary>
        /// Method to select an option from a <Select>List</Select> containing the input text
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="by">Locator of the select element where the option is expected to reside</param>
        /// <param name="text">The text in the option that needs to be selected</param>
        public static void SelectElementByText(this IWebDriver driver, By by, string text)
        {
            driver.WaitForClickable(by);
            try
            {
                var selectElement = new SelectElement(driver.FindElement(by));
                selectElement.SelectByText(text);
            }
            catch (System.Exception)
            {
                Log.Warn($"Unable to select option in the select tag with the text {text}.");
                throw;
            }
            
        }

        /// <summary>
        /// Method to select an option from a <Select>List</Select> containing the input text
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="element">WebElement containing the select list defined in Page Object</param>
        /// <param name="text">The text in the option that needs to be selected</param>
        public static void SelectElementByText(this IWebDriver driver, IWebElement element, string text)
        {
            driver.WaitForClickable(element);
            try
            {
                var selectElement = new SelectElement(element);
                selectElement.SelectByText(text);
            }
            catch (System.Exception)
            {
                Log.Warn($"Unable to select option in the select tag with the text {text}.");
                throw;
            }
            
        }
    }
}
