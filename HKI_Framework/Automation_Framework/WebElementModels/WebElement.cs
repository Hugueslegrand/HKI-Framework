
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.Utilities;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Automation_Framework.WebElementModels
{
    /// <summary>
    /// WebElement class to create web elements
    /// </summary>
    public class WebElement : IButton, IInputField, ITable, ILink, ILabel, IParagraph
    {
       
        private IWebElement _webElement;
        private IList<IWebElement> _webElements;
        private IWebDriver _webDriver;


        public string TagName => _webElement.TagName;

        public string Text => _webElement.Text;

        public bool Enabled => _webElement.Enabled;

        public bool Selected => _webElement.Selected;

        public bool Displayed => _webElement.Displayed;

        public Size Size => _webElement.Size;

        public Point Location => _webElement.Location;

        /// <summary>
        /// Creates web elements 
        /// </summary>
        /// <param name="driver">The running driver instance</param>
        /// <param name="expression">Id, css selector, xpath, etc.. of the element</param>
        /// <param name="selector">Selector to use for element in test, example: find element by CSS, XPath, Id, ...</param>
        public WebElement(IWebDriver driver, string expression, Selector selector)
        {
            _webDriver = driver;
            switch (selector)
            {
                case Selector.Name:
                    _webDriver.Exists(By.Name(expression));
                    _webElement = _webDriver.FindElement(By.Name(expression));
                    _webElements = _webDriver.FindElementAboveZero(By.Name(expression));
                    break;
                case Selector.Id:
                    _webDriver.Exists(By.Id(expression));
                    _webElement = _webDriver.FindElement(By.Id(expression));
                    _webElements = _webDriver.FindElementAboveZero(By.Id(expression));
                    break;
                case Selector.Css:
                    _webDriver.Exists(By.CssSelector(expression));
                    _webElement = _webDriver.FindElement(By.CssSelector(expression));
                    _webElements = _webDriver.FindElementAboveZero(By.CssSelector(expression));
                    break;

                case Selector.Xpath:
                    _webDriver.Exists(By.XPath(expression));
                    _webElement = _webDriver.FindElement(By.XPath(expression));
                    _webElements = _webDriver.FindElementAboveZero(By.XPath(expression));
                    break;

                case Selector.LinkText:
                    _webDriver.Exists(By.LinkText(expression));
                    _webElement = _webDriver.FindElement(By.LinkText(expression));
                    _webElements = _webDriver.FindElementAboveZero(By.LinkText(expression));
                    break;

                case Selector.ClassName:
                    _webDriver.Exists(By.ClassName(expression));
                    _webElement = _webDriver.FindElement(By.ClassName(expression));
                    _webElements = _webDriver.FindElementAboveZero(By.ClassName(expression));
                    break;
                case Selector.TagName:
                    _webDriver.Exists(By.TagName(expression));
                    _webElement = _webDriver.FindElement(By.TagName(expression));
                    _webElements = _webDriver.FindElementAboveZero(By.TagName(expression));
                    break;
                default:
                    new ArgumentOutOfRangeException(nameof(Selector),
                       $"No valid SelectorType given. Selector must be of either types {Selector.LinkText}, {Selector.ClassName}, {Selector.Css}, {Selector.Id}, {Selector.Name}, {Selector.Xpath}.",
                       null);
                    break;
            }
        }


        public void OpenLinkInNewTab()
        {
            _webDriver.OpenLinkInNewTab(_webElement);
        }

        public IWebElement GetElement()
        {
            return _webElement;
        }

        public void ClickOnElement()
        {
            try
            {
                //Maybe put the scroll in screenshot extension
                _webDriver.ExecuteJsObject("arguments[0].scrollIntoView(true);", _webElement);
                _webDriver.ClickOnElement(_webElement);
               
            }
            catch (Exception)
            {

                Log.Warn($"Failed to click on the {_webElement.TagName} `{_webElement.Text}` {_webElement}");
                throw;
            }
            

        }


        public IList<IWebElement> GetElements()
        {
            return _webElements;
        }
        public void SendKeys(string text)
        {
            try
            {
                _webElement.SendKeys(text);
            }
            catch (Exception)
            {
                Log.Warn($"Failed to send the text `{_webElement.Text}` in the {_webElement.TagName} ");
                throw;
            }
            
        }

        public string GetCssValue(string propertyName)
        {
            Log.Info($"Retrieving the css value with propertyName {propertyName}");
            return _webElement.GetCssValue(propertyName);
        }

        public string GetAttribute(string attributeName)
        {
            Log.Info($"Retrieving the attribute value with attribute name {attributeName}");
            return _webElement.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            Log.Info($"Retrieving the property value with propertyName {propertyName}");
            return _webElement.GetProperty(propertyName);
        }

        public void ClearInput()
        {
            try
            {
                _webElement.Clear();
                Log.Info($"Cleared the {_webElement.TagName}");
            }
            catch (Exception)
            {
                Log.Warn($"Unable to clear the {_webElement.TagName}");
                throw;
            }
            
        }

       
    }
}
