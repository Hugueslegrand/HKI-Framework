using Automation_Framework.Utilities;
using Automation_Framework.Helpers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.UI;
using System;


namespace Automation_Framework.Extensions.MobileDriver
{
    /// <summary>
    /// A wait extension class for mobile
    /// </summary>
    public static class MobileWaitExtension
    {
        /// <summary>
        /// Used for the defaultimeout wait specified in appSettings
        /// </summary>
        /// <param name="driver">Containts the mobile android driver used to run the test in</param>
        /// <returns>A WebDriverWait function</returns>
        public static WebDriverWait AndroidWait(this AppiumDriver<AndroidElement> driver)
        {
           
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.NativeMobileDriver.DefaultTimeout));
        }

        /// <summary>
        /// Used for the defaultimeout wait specified in appSettings
        /// </summary>
        /// <param name="driver">Containts the mobile ios driver used to run the test in</param>
        /// <returns>A WebDriverWait function</returns>
        public static WebDriverWait IOSWait(this AppiumDriver<IOSElement> driver)
        {
            
            return new WebDriverWait(driver,
                TimeSpan.FromSeconds(Configuration.NativeMobileDriver.DefaultTimeout));
        }

        /// <summary>
        /// Waits until an element is clickable
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <param name="element">IOSElement defined in Page Object which should become clickable</param>
        
        public static void WaitForClickableIOS(this AppiumDriver<IOSElement> driver, IOSElement element)
        {
         
                driver.IOSWait().Until(ExpectedConditions.ElementToBeClickable(element));
           

        }

        /// <summary>
        /// Waits until an element is clickable
        /// </summary>
        /// <param name="driver">Containts the driver used to run the test in</param>
        /// <param name="by">AndroidElement defined in Page Object which should become clickable</param>
        
        public static void WaitForClickableAndroid(this AppiumDriver<AndroidElement> driver, AndroidElement element)
        {
           
                driver.AndroidWait().Until(ExpectedConditions.ElementToBeClickable(element));
           

          
        }
    }
}
