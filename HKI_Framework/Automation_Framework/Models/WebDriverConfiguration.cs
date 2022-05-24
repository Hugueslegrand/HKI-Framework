
using Automation_Framework.Enums;

namespace Automation_Framework.Models
{
    /// <summary>
    /// WebDriverConfiguration Model
    /// </summary>
    public class WebDriverConfiguration
    {
        /// <summary>
        /// Browser to run the test in
        /// </summary>
        public BrowserName BrowserName { get; set; }
        /// <summary>
        /// Setting the language of the browser
        /// </summary>
        public string BrowserLanguage { get; set; }
        /// <summary>
        /// Wait time in seconds
        /// </summary>
        public int DefaultTimeout { get; set; }

        public BrowserType BrowserType { get; set; }

        public string GridUrl { get; set; }

        public string PathToDrivers { get; set; }

    }
}
