using System;
using System.IO;
using System.Linq;
using System.Threading;
using Allure.Commons;
using Automation_Framework.Helpers;
using Automation_Framework.Utilities;
using OpenQA.Selenium;



namespace Automation_Framework.Extensions.WebDriver
{

    /// <summary>
    /// A screenshot extension class for web
    /// </summary>
    public static class ScreenshotTaker
    {

        /// <summary>
        /// Takes a standard (fullscreen) screenshot
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="fileName">Name of the saved screenshot </param>
        public static void TakeStandardScreenshot(this IWebDriver driver, string fileName)
        {
            driver.SaveScreenshot(fileName);
            
        }

        /// <summary>
        /// Saves a screenshot in a specified filepath with a filename
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="fileName">Name of the saved screenshot </param>
        private static void SaveScreenshot(this IWebDriver driver, string fileName)
        {
            try
            {
                var fileNameSave = GetFileNameSave(fileName);
                var pathToFile = GetFilePath(GetFileNameSave(fileNameSave));

                driver.ScreenshotSaveLocation(pathToFile);
                AllureLifecycle.Instance.AddAttachment(pathToFile, fileNameSave);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Taking a screenshot failed: {ex.Message}");
            }
        }


        /// <summary>
        /// Method to set the location of the saved screenshot, which can be used in the SaveScreenshot() method
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="pathToFile">Path to which the screenshot gets saved </param>
        private static void ScreenshotSaveLocation(this IWebDriver driver, string pathToFile)
        {
            var screenshot = ((ITakesScreenshot)GetBaseDriver(driver)).GetScreenshot();
            screenshot.SaveAsFile(pathToFile, ScreenshotImageFormat.Png);
        }

        /// <summary>
        /// Method to return saved filename 
        /// </summary>
        /// <param name="fileName">Name of the saved screenshot in the code </param>
        /// <returns>Returns the actual filename of the screenshot in the filepath</returns>
        private static string GetFileNameSave(string fileName)
        {
            return Path.GetInvalidFileNameChars()
                .Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        /// <summary>
        /// Method to return the location of the saved filename 
        /// </summary>
        /// <param name="fileName">Name of the saved screenshot in the code </param>
        /// <returns>Returns the filepath of the defined file</returns>
        private static string GetFilePath(string fileName)
        {
            var path = "";
            if (Configuration.Logger is not null)
            {
                 path = $"{Configuration.Logger.LogsPath}\\{fileName}{DateTime.Now:HH}";
            }
            
            Directory.CreateDirectory(path);
            var pathToFile =
                $"{path}\\{GetFileNameSave(DateTime.UtcNow.ToLongTimeString())}_{Thread.CurrentThread.ManagedThreadId}.png";
            return pathToFile;
        }

        /// <summary>
        /// Method to return the used driver, which will be used to determine the save location in ScreenshotSaveLocation()
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        private static IWebDriver GetBaseDriver(IWebDriver driver)
        {
            if (driver is DriverListener webDriverListener)
            {
                return webDriverListener.WrappedDriver;
            }

            return driver;
        }
    }
}