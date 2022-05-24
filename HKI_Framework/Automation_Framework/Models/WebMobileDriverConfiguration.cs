
using Automation_Framework.Enums;

namespace Automation_Framework.Models
{
    /// <summary>
    /// WebMobileDriverConfiguration Model
    /// </summary>
    public class WebMobileDriverConfiguration
    {
        /// <summary>
        /// Browser to run the test in
        /// </summary>
        public BrowserName BrowserName { get; set; }
        /// <summary>
        /// Name of the Automation to be used 
        /// </summary>
        public string AutomationName { get; set; }
        /// <summary>
        /// Name of the Platform to run the tests
        /// </summary>
        public string PlatformName { get; set; }
        /// <summary>
        /// Name of the device to be used
        /// </summary>
        public string DeviceName { get; set; }
    }
}
