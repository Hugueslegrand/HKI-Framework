using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;


namespace Automation_Framework.Extensions.WebDriver
{
    /// <summary>
    /// An list generating from elements class for web
    /// </summary>
    public static class Populator
    {
        /// <summary>
        /// Method to return all values as text from a List of WebElements in a List
        /// </summary>
        /// <param name="elementList">The list containing the WebElements of which we want the text from</param>
        /// <returns>List containing text of the WebElements</returns>
        public static List<string> TextReaderFromList(this IList<IWebElement> elementList)
        {
            List<string> allRowsText = elementList.Select(x => x.Text).ToList();
            return allRowsText;
        }

        /// <summary>
        /// Method to return all values from a certain column as text in a List 
        /// </summary>
        /// <param name="elementList">The List containing the WebElements</param>
        /// <param name="by">Locator of the select element where the option is expected to reside</param>
        /// <param name="columnIndex">Index of the column of which the values should be extracted</param>
        /// <returns>Returns a List of text containing the values from the specified column</returns>
        public static List<string> GetAllRowValuesFromColumn(this IList<IWebElement> elementList, int columnIndex, By by)
        {
            List<string> allRowsText = elementList
                                       .Select(x => x.FindElements(by)
                                       .ElementAt(columnIndex).Text).ToList();
            return allRowsText;
        }

        /// <summary>
        /// Method to return all values form a Dropdown list with WebElements
        /// </summary>
        /// <param name="elementList">The List containing the WebElements</param>
        /// <returns>Returns a List of text containing the values from the specified dropdown List</returns>
        public static List<string> GetValuesFromDropDown(this IList<IWebElement> elementList)

        {
            List<string> dropdownValues = elementList.Select(x => x.Text).ToList();

            return dropdownValues;

        }

        /// <summary>
        /// Method to return all values form a <Select></Select> dropdown 
        /// </summary>
        /// <param name="element">The List containing the WebElements</param>
        /// <returns>Returns a List of text containing the values from the specified dropdown Select Tag dropdown</returns>
        public static List<string> GetAllOptionsFromSelectTagDropDown(this IWebElement element)
        {
            SelectElement SelectTagddl = new SelectElement(element);

            return SelectTagddl.Options.Select(x => x.Text).ToList();
        }
    }
}
