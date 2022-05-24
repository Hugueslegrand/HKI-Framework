using Automation_Framework.Enums;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Extensions.MobileDriver
{
   
    /// <summary>
    /// A Swipe extension class for mobile
    /// </summary>
    public static class SwipeExtension
    {
        /// <summary>
        /// Method for performing swipe touch actions on screen
        /// </summary>
        /// <param name="driver">Containts the mobile android driver used to run the test in</param>
        /// <param name="startX">The x coordinates on the screen where the touch begins</param>
        /// <param name="startY">The y coordinates on the screen where the touch begins</param>
        /// <param name="endX">The x coordinates on the screen where the touch ends</param>
        /// <param name="endX">The y coordinates on the screen where the touch ends</param>
        /// <param name="duration">The time in milliseconds in which the swipe should be performed</param>
        public static void Swipe(this AppiumDriver<AndroidElement> driver, int startX, int startY, int endX, int endY, int duration)
        {
            ITouchAction touchAction = new TouchAction(driver)
            .Press(startX, startY)
            .Wait(duration)
            .MoveTo(endX, endY)
            .Release();

            touchAction.Perform();
        }

       
    }
}
