

using System.Drawing;

namespace Automation_Framework.WebElementModels
{
    /// <summary>
	/// Structural interface for an Android element
	/// </summary>
    public interface IAndroidElement
    {
        /// <summary>
        /// Gets the tag name of this element
        /// </summary>
        /// Remarks: The TagName property returns the tag name of the element, not the value of the name attribute. 
        /// For example, it will return "input" for an element specified by the HTML markup <input name="foo" />
        string AndroidTagName { get; }
        /// <summary>
        /// Gets the innerText of this element, without any leading or trailing whitespace, and with other whitespace collapsed.
        /// </summary>
        string AndroidText { get; }
        /// <summary>
        /// Gets a value indicating whether or not this element is enabled.
        /// </summary>
        /// Remarks: The Enabled property will generally return true for everything except explicitly disabled input elements.
        bool AndroidEnabled { get; }
        /// <summary>
        /// Gets a value indicating whether or not this element is selected.
        /// </summary>
        /// Remarks: This operation only applies to input elements such as checkboxes, options in a select element and radio buttons.
        bool AndroidSelected { get; }
        /// <summary>
        /// Gets a value indicating whether or not this element is displayed.
        /// </summary>
        /// Remarks: The Displayed property avoids the problem of having to parse an element's "style" attribute to determine visibility of an element.
        bool AndroidDisplayed { get; }
        /// <summary>
        /// Gets a Size object containing the height and width of this element.
        /// </summary>
        Size AndroidSize { get; }
        /// <summary>
        /// Gets a System.Drawing.Point object containing the coordinates of the upper-left corner of this element relative to the upper-left corner of the page.
        /// </summary>
        Point AndroidLocation { get; }

        /// <summary>
        /// Method used for clicking on an element, after waiting for it to be clickable
        /// </summary>
        void AndroidClick();
        /// <summary>
        /// Clears the content of this element.
        /// </summary>
        /// Remarks: If this element is a text entry element, the Clear method will clear the value. It has no effect on other elements. 
        /// Text entry elements are defined as elements with INPUT or TEXTAREA tags.
        void AndroidClear();
        /// <summary>
        /// Simulates typing text into the element.
        /// </summary>
        ///  <param name="text">The text to type into the element</param>
        /// Remarks: The text to be typed may include special characters like arrow keys, backspaces, function keys, and so on. 
        /// Valid special keys are defined in OpenQA.Selenium.Keys.
        void AndroidSendKeys(string text);

        /// <summary>
        /// Method for performing swipe touch actions on screen
        /// </summary>
        /// <param name="startX">The x coordinates on the screen where the touch begins</param>
        /// <param name="startY">The y coordinates on the screen where the touch begins</param>
        /// <param name="endX">The x coordinates on the screen where the touch ends</param>
        /// <param name="endX">The y coordinates on the screen where the touch ends</param>
        /// <param name="duration">The time in milliseconds in which the swipe should be performed</param>
        void Swipe(int startX, int startY, int endX, int endY, int duration);
    }
}
