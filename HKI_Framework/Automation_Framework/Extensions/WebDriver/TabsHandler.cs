using Automation_Framework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Extensions.WebDriver
{
    /// <summary>
    /// A browser tab extension class for web
    /// </summary>
    public static class TabsHandler
    {

        /// <summary>
        /// Switches to a browser tab based on the given index 
        /// </summary>
        /// <param name="driver">Contains the driver used to run the test in</param>
        /// <param name="tabIndex">The index of the tab</param>
        public static void SwitchToASpecificTab(this IWebDriver driver,int tabIndex)
        {
            driver.SwitchTo().Window(driver.WindowHandles[tabIndex]);
            Log.Info($"Switched to tab number {tabIndex+1}");
        }

        

       
    }
}
