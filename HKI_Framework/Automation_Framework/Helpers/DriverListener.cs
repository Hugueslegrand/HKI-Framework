
using Automation_Framework.Extensions.WebDriver;
using LLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;

namespace Automation_Framework.Helpers
{
    /// <summary>
    /// A helper class for logging actions made on the WebDriver
    /// </summary>
    public class DriverListener : EventFiringWebDriver
    {
        private readonly IWebDriver _driver;
        private readonly L _logger;

        /// <summary>
        /// Initializes an androidDriver
        /// </summary>
        /// <param name="parentDriver">Contains the running WebDriver instance. This WebDriver will be wrapped by EventFiringWebDriver that will add the support of event triggering.</param>
        /// <param name="logger">LLibrary class for logging actions made on the web driver</param>
        

        public DriverListener(IWebDriver parentDriver, L logger) : base(parentDriver)
        {
            _driver = parentDriver;
            _logger = logger;

            Navigating += WebDriverListener_Navigating;
            Navigated += WebDriverListener_Navigated;
            FindingElement += WebDriverListener_FindingElement;
            ElementClicking += WebDriverListener_ElementClicking;
            ElementClicked += WebDriverListener_ElementClicked;
            ElementValueChanged += WebDriverListener_ElementValueChanged;
          
        }

      
        /// <summary>
        /// Fires before the driver begins navigation and logs it
        /// </summary>
        /// <param name="e">Provides data for events relating to navigation</param>
        private void WebDriverListener_Navigating(object sender,
            WebDriverNavigationEventArgs e)
        {
            LogMessage($"Navigating to {e.Url}");
        }

        /// <summary>
        /// Fires after the driver has clicked on an element and logs it
        /// </summary>
        /// <param name="e">Provides data for events relating to elements</param>
        private void WebDriverListener_ElementClicked(object sender,
            WebElementEventArgs e)
        {
            LogMessage($"clicked on {e.Element} ");
        }

        /// <summary>
        /// Fires before the driver has clicked on an element and logs it
        /// </summary>
        /// <param name="e">Provides data for events relating to elements</param>
        private void WebDriverListener_ElementClicking(object sender,
            WebElementEventArgs e)
        {
            LogMessage($"Clicking on the {e.Element.TagName} `{e.Element.Text}` {e.Element}");
        }

        /// <summary>
        /// Fires before the driver starts to find an element and logs it
        /// </summary>
        /// <param name="e">Provides data for events relating to elements</param>
        private void WebDriverListener_FindingElement(object sender,
            FindElementEventArgs e)
        {
            LogMessage($"Finding element `{e.FindMethod}`");
        }

        /// <summary>
        /// Fires after the driver has changed the value of an element via Clear(), SendKeys() or Toggle() and logs it
        /// </summary>
        /// <param name="e">Provides data for events relating to finding elements</param>
        private void WebDriverListener_ElementValueChanged(object sender,
            WebElementValueEventArgs e)
        {
            LogMessage($"Value of the {e.Element.TagName} changed to `{e.Value}`");
         
        }

        /// <summary>
        /// Fires after the driver completes navigation and logs it
        /// </summary>
        /// <param name="e">Provides data for events relating to navigation</param>
        private void WebDriverListener_Navigated(object sender,
            WebDriverNavigationEventArgs e)
        {

            LogMessage($"Navigated to [{e.Driver.Title}]({e.Url})");
        }

        /// <summary>
        /// Method for making log messages with LLogger library
        /// </summary>
        /// <param name="text">log message text</param>
        private void LogMessage(string text)
        {
            _logger.Info(text);
        }

        /// <summary>
        /// Method for logging the taken screenshots
        /// </summary>
        /// <param name="text">Text describing the taken screenshot</param>
        private void LogScreenshot(string text)
        {
            ScreenshotTaker.TakeStandardScreenshot(_driver, text);
        }
    }
}
