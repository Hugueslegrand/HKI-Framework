using Automation_Framework.Builders;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System.Collections.ObjectModel;
using System.Threading;

namespace Automation_Framework.Base
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        protected readonly AndroidDriver<AndroidElement> AndroidDriver;
        protected readonly IOSDriver<IOSElement> IOSDriver;



        protected BasePage(DriverBuilder driver)
        {
            Driver = driver._webDriver;
            AndroidDriver = driver._androidDriver;
            IOSDriver = driver._iosDriver;
        }

        
    }
}
