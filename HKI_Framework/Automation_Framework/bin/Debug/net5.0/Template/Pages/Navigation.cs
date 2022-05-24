using Automation_Framework.Builders;
using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;


namespace Automation_Framework.Tests.Pages
{
    public class Navigation : BasePage
    {
        public Navigation(DriverBuilder driver) : base(driver) { }
        public IButton SignInButton => new WebElement(Driver, "//button[@id='SignInButton']", Selector.Xpath);
        public IInputField SearchBar => new WebElement(Driver, ".MuiInputBase-root.MuiOutlinedInput-root.MuiAutocomplete-inputRoot.jss1.MuiInputBase-fullWidth.MuiInputBase-formControl.MuiInputBase-adornedEnd.MuiOutlinedInput-adornedEnd", Selector.Css);

        public IInputField SearchBarDropDown => new WebElement(Driver, "div.css-1optmax > div > div > div > input", Selector.Css);

        public IButton DropdownNoOption => new WebElement(Driver, "MuiAutocomplete-noOptions", Selector.ClassName);

        public IButton DropdownAWhiskerAway => new WebElement(Driver, "//li[contains(text(),'A Whisker Away')]", Selector.Xpath);

        public IButton DropdownDemonSlayer => new WebElement(Driver, "//li[contains(text(),'Demon Slayer the Movie: Mugen Train')]", Selector.Xpath);

        public IButton Logo => new WebElement(Driver, "//img[@id='Logo']", Selector.Xpath);
        public IButton RegisterButton => new WebElement(Driver, "//button[@id='RegisterButton']", Selector.Xpath);
        public IButton MyMovieButton => new WebElement(Driver, "//a[@href='#/orders']//button[@id='OrdersPageButton']", Selector.Xpath);
        public IButton ProfileButton => new WebElement(Driver, "//a[@href='#/profile']//button[@id='OrdersPageButton']", Selector.Xpath);
        public IButton SignOutButton => new WebElement(Driver, "//button[@id='SignOutButton']", Selector.Xpath);
        public IButton SettingsButton => new WebElement(Driver, "(//*[name()='svg'][@class='css-t5s0nn'])[1]", Selector.Xpath);
  

    }
}
