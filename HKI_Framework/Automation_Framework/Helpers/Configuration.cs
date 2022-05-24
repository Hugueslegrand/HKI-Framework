using Automation_Framework.Models;
using Automation_Framework.TestRail.Model;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Automation_Framework.Helpers
{
    public class Configuration
    {
        // initialized as logger
        private const string LoggerConfigSectionName = "logger";

        // initialized as testrail
        private const string TestRailConfigSectionName = "testrail";

        // initialized as webdriver
        private const string WebDriverConfigSectionName = "webdriver";

        // initialized as environment
        private const string EnvironmentConfigSectionName = "environment";

        // initialized as nativeMobile
        private const string NativeMobileDriverConfigSectionName = "nativeMobile";

        // initialized as webMobile
        private const string WebMobileDriverConfigSectionName = "webMobile";

        /// <summary>
        /// Load configuration file with section name logger  
        /// </summary>
        public static LoggerConfiguration Logger =>
          Load<LoggerConfiguration>(LoggerConfigSectionName);

        /// <summary>
        /// Load configuration file with section name testrail  
        /// </summary>
        public static TestRailConfiguration TestRail =>
          Load<TestRailConfiguration>(TestRailConfigSectionName);

        /// <summary>
        /// Load configuration file with section name webDriver  
        /// </summary>
        public static WebDriverConfiguration WebDriver =>
            Load<WebDriverConfiguration>(WebDriverConfigSectionName);

        /// <summary>
        /// Load configuration file with section name nativeMobile
        /// </summary>
        public static NativeMobileDriverConfiguration NativeMobileDriver =>
           Load<NativeMobileDriverConfiguration>(NativeMobileDriverConfigSectionName);

        /// <summary>
        /// Load configuration file with section name webMobile
        /// </summary>
        public static WebMobileDriverConfiguration WebMobileDriver =>
             Load<WebMobileDriverConfiguration>(WebMobileDriverConfigSectionName);

        /// <summary>
        /// Load configuration file with section name environment  
        /// </summary>
        public static EnvironmentConfiguration Environment =>
         Load<EnvironmentConfiguration>(EnvironmentConfigSectionName);

       

        /// <summary>
        /// Choses the section to load based on the section name
        /// </summary>
        /// <param name="sectionName">The section that should be chosen</param>
        private static T Load<T>(string sectionName)
        {
            return new ConfigurationBuilder().AddJsonFile("appSettings.json")
                          .Build().GetSection(sectionName).Get<T>();
        }

    }
}
