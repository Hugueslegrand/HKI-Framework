

namespace Automation_Framework.Enums
{
    /// <summary>
    /// Enum of selectors to use for a specific element id, css selector or xpath value
    /// </summary>
    public enum Selector
    {
        /// <summary>
        /// Fallback to set enum to default value in switch
        /// </summary>
        Name,
        /// <summary>
        /// Find element by Id
        /// </summary>
        Id,
        /// <summary>
        /// Find element by CSS selector
        /// </summary>
        Css,
        /// <summary>
        /// Find element by XPath
        /// </summary>
        Xpath,
        /// <summary>
        /// Find element by LinkText
        /// </summary>
        LinkText,
        /// <summary>
        /// Find element by ClassName
        /// </summary>
        ClassName,
        /// <summary>
        /// Find element by TagName
        /// </summary>
        TagName


    }
}
