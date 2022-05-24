

namespace Automation_Framework.Enums
{
    /// <summary>
    /// Enum of selectors to use for a specific element name, class name, id, accessibilityID, css or xpath value
    /// </summary>
    public enum MobileSelector
    {
        /// <summary>
        /// Find element by Name    
        /// </summary>
        Name,
        /// <summary>
        /// Find element by Id
        /// </summary>
        Id,
        /// <summary>
        /// Find element by XPath
        /// </summary>
        Xpath,
        /// <summary>
        /// Find element by Class Name
        /// </summary>
        ClassName,
        /// <summary>
        /// Find element by Accessibility ID
        /// </summary>
        AccessibilityID,
        /// <summary>
        /// Find element by CSS selector
        /// </summary>
        Css,


    }
}
