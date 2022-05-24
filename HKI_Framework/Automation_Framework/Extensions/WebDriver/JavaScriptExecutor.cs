using OpenQA.Selenium;
using Automation_Framework.Utilities;

namespace Automation_Framework.Extensions.WebDriver
{
    /// <summary>
    /// A JavaScriptExecutor extension class for web
    /// </summary>
    public static class JavaScriptExecutor
    {
        /// <summary>
        /// Method that allows to run a JS script in the driver
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="script">The script that has to be executed</param>
        /// <returns>Returns the value returned by the script</returns>
        public static object ExecuteJs(this IWebDriver driver, string script)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            Log.Info($"Executed the script `{script}`");
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
        /// <summary>
        /// Method that allows to run a JS script in the driver
        /// </summary>
        /// <param name="driver">The web driver</param>
        /// <param name="script">The script that has to be executed</param>
        /// <param name="args">The arguments to the script.</param>
        /// <returns>Returns the value returned by the script</returns>
        public static object ExecuteJsObject(this IWebDriver driver, string script,object args)
        {
            if (driver is null) Log.Warn("The driver has not been build");
            return ((IJavaScriptExecutor)driver).ExecuteScript(script,args);
        }

    }
}