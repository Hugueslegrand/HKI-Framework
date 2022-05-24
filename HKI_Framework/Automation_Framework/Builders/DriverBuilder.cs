using Automation_Framework.Helpers;
using Automation_Framework.Models;
using Automation_Framework.Utilities;
using LLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;


namespace Automation_Framework.Builders
{
    public class DriverBuilder
    {

        public IWebDriver _webDriver;
        public AndroidDriver<AndroidElement> _androidDriver;
        public IOSDriver<IOSElement> _iosDriver;

        private WebDriverConfiguration driverConfig = Configuration.WebDriver;
        private NativeMobileDriverConfiguration nativeMobileConfig = Configuration.NativeMobileDriver;
        private WebMobileDriverConfiguration webMobileConfig = Configuration.WebMobileDriver;
        private string url = Configuration.Environment.ApplicationUrl;

        
        /// <summary>
        /// Creates a new driver client based on the chosen PlatformType
        /// </summary>
        /// <param name="platformType">The platformtype.</param>
        /// <returns>This method will return a driver instance based on the PlatformType, allowing users to issue commands on that said driver. 
        /// An ArgumentOutOfRangeException will be thrown if the selected platform is not supported.</returns>
        public IWebDriver BuildDriver(Enums.PlatformType platformType)
        {

            L logger = Log.logger;
            switch (platformType)
            {
                case Enums.PlatformType.Desktop:

                    _webDriver = new DriverFactory().GetWebDriver(driverConfig, logger);

                    _webDriver.Manage().Window.Maximize();
                   
                    _webDriver.Navigate().GoToUrl(url);

                    return _webDriver;

                case Enums.PlatformType.Android:
                    _androidDriver = new DriverFactory().GetNativeAndroidDriver(nativeMobileConfig);

                    return _androidDriver;

                case Enums.PlatformType.IOS:
                    _iosDriver = new DriverFactory().GetNativeIOSDriver(nativeMobileConfig);

                    return _iosDriver;

                case Enums.PlatformType.WebAndroid:
                    _androidDriver = new DriverFactory().GetWebAndroidDriver(webMobileConfig);


                    _androidDriver.Navigate().GoToUrl(url);

                    return _webDriver;

                case Enums.PlatformType.WebIOS:
                    _iosDriver = new DriverFactory().GetWebIOSDriver(webMobileConfig);


                    _iosDriver.Navigate().GoToUrl(url);

                    return _webDriver;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Enums.PlatformType),
                        $"No valid PlatformType given. Platform must be of either types PlatformType.Android, PlaformType.IOS, PlatformType.WebAndroid, PlatformType.WebIOS.",
                        null);
            }
        }

        /// <summary>
        /// Close a driver client based on the chosen PlatformType
        /// </summary>
        /// <param name="platformType">The platformtype.</param>
        public void CloseDriver(Enums.PlatformType platformType)
        {
            switch (platformType)
            {
                case Enums.PlatformType.Desktop:
                    if (_webDriver != null) _webDriver.Quit();
                    break;
                case Enums.PlatformType.Android:
                    if (_androidDriver != null) _androidDriver.Quit();
                    break;
                case Enums.PlatformType.IOS:
                    if (_iosDriver != null) _iosDriver.Quit();
                    break;
                case Enums.PlatformType.WebAndroid:
                    if (_androidDriver != null) _androidDriver.Quit();
                    break;
                case Enums.PlatformType.WebIOS:
                    if (_iosDriver != null) _iosDriver.Quit();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Enums.PlatformType),
                        $"No valid PlatformType given. Platform must be of either types PlatformType.Android, PlaformType.IOS, PlatformType.WebAndroid, PlatformType.WebIOS.",
                        null);
            }
        }

        /// <summary>
        /// This method will close all currently running driver instances
        /// </summary>
        public void CloseAllDrivers()
        {
            if (_webDriver!=null)  _webDriver.Quit();
               
            if (_androidDriver != null) _androidDriver.Quit();
                
            if (_iosDriver != null)  _iosDriver.Quit();
               
        }

    }
}
