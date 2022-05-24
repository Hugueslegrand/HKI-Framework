using Automation_Framework.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;


namespace Automation_Framework.Helpers
{
    /// <summary>
    /// A helper class for options on the WebDriver and appiumDriver
    /// </summary>
    public class DriverSettings
    {
        /// <summary>
        /// Setting options for Chrome
        /// </summary>
        /// <param name="config">Contains configuration for creating a WebDriver instance</param>
        /// <returns>Returns chrome options</returns>

        public static ChromeOptions ChromeOptions(WebDriverConfiguration config)
        {
            ChromeOptions options = new ChromeOptions();

            options.AddExcludedArgument("enable-automation");
            options.AddArgument("--disable-save-password-bubble");
            options.AddArgument("ignore-certificate-errors");
            options.AddArgument("start-maximized");
            options.AddArgument("no-sandbox");

            options.AddArgument($"--lang={config.BrowserLanguage}");
            options.AddUserProfilePreference("intl.accept_languages", config.BrowserLanguage);

            return options;
        }

        /// <summary>
        /// Setting options for Firefox
        /// </summary>
        /// <param name="config">Contains configuration for creating a WebDriver instance</param>
        /// <returns>Returns firefox options</returns>
        public static FirefoxOptions FirefoxOptions(WebDriverConfiguration config)
        {
            FirefoxOptions options = new FirefoxOptions { AcceptInsecureCertificates = true };
            options.AddArgument("start-maximized");
            options.SetPreference("intl.accept_languages", config.BrowserLanguage);

            return options;
        }

        /// <summary>
        /// Setting options for IE
        /// </summary>
        /// <returns>Returns IE options</returns>
        public static InternetExplorerOptions InternetExplorerOptions()
        {

            return new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                IgnoreZoomLevel = false,

            };
        }
        /// <summary>
        /// Setting options for Safari
        /// </summary>
        /// <returns>Returns safari options</returns>
        public static SafariOptions SafariOptions()
        {
            SafariOptions options = new SafariOptions();


            return options;
        }
        /// <summary>
        /// Setting options for Edge
        /// </summary>
        /// <returns>Returns edge options</returns>
        public static EdgeOptions EdgeOptions()
        {
            EdgeOptions options = new EdgeOptions();


            options.PageLoadStrategy = PageLoadStrategy.Normal;


            return options;
        }
        /// <summary>
        /// Setting options for Opera
        /// </summary>
        /// <returns>Returns opera options</returns>
        public static OperaOptions OperaOptions()
        {
            OperaOptions options = new OperaOptions();
            options.AddArgument("start-maximized");

            options.PageLoadStrategy = PageLoadStrategy.Normal;


            return options;
        }

        /// <summary>
        /// Setting options for mobile
        /// </summary>
        /// <param name="config">Contains model for native mobile driver configuration</param>
        /// <returns>Returns appium options for native mobile</returns>
        public static AppiumOptions NativeMobileOptions(NativeMobileDriverConfiguration config)
        {
            AppiumOptions options = new AppiumOptions();

            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, config.PlatformName);
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, config.AutomationName);
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, config.DeviceName);
            options.AddAdditionalCapability(MobileCapabilityType.App, config.App);
            return options;
        }

        /// <summary>
        /// Setting options for mobile
        /// </summary>
        /// <param name="config">Contains model for web mobile driver configuration</param>
        /// <returns>Returns appium options for web mobile</returns>
        public static AppiumOptions WebMobileOptions(WebMobileDriverConfiguration config)
        {
            AppiumOptions options = new AppiumOptions();

            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, config.PlatformName);
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, config.AutomationName);
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, config.DeviceName);
            options.AddAdditionalCapability(MobileCapabilityType.BrowserName, config.BrowserName);
            return options;
        }
    }


}