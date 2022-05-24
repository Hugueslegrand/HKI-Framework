using OpenQA.Selenium;
using System.Collections.Generic;
using System.Drawing;

namespace Automation_Framework.WebElementModels
{
    /// <summary>
    /// Structural interface for a table
    /// </summary>
    public interface ITable
    {
        /// <summary>
        /// Gets the tag name of this element
        /// </summary>
        /// Remarks: The TagName property returns the tag name of the element, not the value of the name attribute. 
        /// For example, it will return "input" for an element specified by the HTML markup <input name="foo" />
        string TagName { get; }
        /// <summary>
        /// Gets the innerText of this element, without any leading or trailing whitespace, and with other whitespace collapsed.
        /// </summary>
        string Text { get; }
        /// <summary>
        /// Gets a value indicating whether or not this element is enabled.
        /// </summary>
        /// Remarks: The Enabled property will generally return true for everything except explicitly disabled input elements.
        bool Enabled { get; }
        /// <summary>
        /// Gets a value indicating whether or not this element is selected.
        /// </summary>
        /// Remarks: This operation only applies to input elements such as checkboxes, options in a select element and radio buttons.
        bool Selected { get; }
        /// <summary>
        /// Gets a value indicating whether or not this element is displayed.
        /// </summary>
        /// Remarks: The Displayed property avoids the problem of having to parse an element's "style" attribute to determine visibility of an element.
        bool Displayed { get; }
        /// <summary>
        /// Gets a Size object containing the height and width of this element.
        /// </summary>
        Size Size { get; }
        /// <summary>
        /// Gets a System.Drawing.Point object containing the coordinates of the upper-left corner of this element relative to the upper-left corner of the page.
        /// </summary>
        Point Location { get; }

        /// <summary>
        /// Gets the value of a CSS property of this element.
        /// </summary>
        ///  <param name="propertyName">The name of the CSS property to get the value of.</param>
        /// Remarks: The values returned is unpredictable in cross-browser environment. Color values will for example return the hex string of the color.
        /// E.g. a "background-color" property set as "green" in the HTML source, will return "#008000" for its value. A StaleElementReferenceException 
        /// will be thrown when the target element is no longer valid in the document DOM.
        string GetCssValue(string propertyName);
        /// <summary>
        /// Gets the value of an Attribute property of this element.
        /// </summary>
        ///  <param name="attributeName">The name of the attribute</param>
        /// Remarks: The GetAttribute(String) method will return the current value of the attribute, even if the value has been modified after the page 
        /// has been loaded. Note that the value of the following attributes will be returned even if there is no explicit attribute on the element
        string GetAttribute(string attributeName);
        /// <summary>
        /// Gets the value of a JavaScript property of this element
        /// The JavaScript property's current value. Returns a null if the value is not set or the property does not exist.
        /// </summary>
        ///  <param name="propertyName">The name JavaScript the JavaScript property to get the value of</param>
        string GetProperty(string propertyName);
        /// <summary>
        /// Method used for clicking on an element, after waiting for it to be clickable
        /// </summary>
        void ClickOnElement();
        /// <summary>
        /// Returns a list of elements
        /// </summary>
        IList<IWebElement> GetElements();
        /// <summary>
        /// Returns an element
        /// </summary>
        IWebElement GetElement();


    }
}
