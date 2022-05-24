
namespace Automation_Framework.Models
{
    /// <summary>
    /// NativeMobileDriverConfiguration Model
    /// </summary>
    public class NativeMobileDriverConfiguration
    {
        /// <summary>
        /// Wait time in seconds
        /// </summary>
        public int DefaultTimeout { get; set; }
        /// <summary>
        /// Name of the Automation to be used 
        /// </summary>
        public string? AutomationName { get; set; }
        /// <summary>
        /// Name of the Platform to run the tests
        /// </summary>
        public string? PlatformName { get; set; }
        /// <summary>
        /// Name of the device to be used
        /// </summary>
        public string? DeviceName { get; set; }
        /// <summary>
        /// path to the apk or ipa files
        /// </summary>
        public string? App { get; set; }

    }
}
