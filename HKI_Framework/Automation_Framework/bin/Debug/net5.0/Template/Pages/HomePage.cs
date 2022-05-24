using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;

using System.Linq;
using Automation_Framework.Extensions.WebDriver;

namespace Automation_Framework.Tests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(DriverBuilder driver) : base(driver) { }


        public IButton MovieBannerButton => new WebElement(Driver, "//div[@id='Comedy Movies']//img[@id='531219']", Selector.Xpath);

        public ILink BrightestOfficalSite => new WebElement(Driver, "//a[@class='css-mi3e9x']", Selector.Xpath);
        public ILink BrightestFaceBookSocials => new WebElement(Driver, "//a[@href='https://www.facebook.com/BrightestNV']", Selector.Xpath);
        public ILink BrightestTwitterSocials => new WebElement(Driver, "//a[@href='https://twitter.com/brightestnv']", Selector.Xpath);
        public ILink BrightestInstagramSocials => new WebElement(Driver, "//a[@href='https://www.instagram.com/brightestsoftwarequality/']", Selector.Xpath);
        public ILink BrightestLinkedInSocials => new WebElement(Driver, "//a[@href='https://www.linkedin.com/company/brightest-nv/']", Selector.Xpath);
        public IButton RentThisMovieButton => new WebElement(Driver, "//button[@id='RentMovieButton']", Selector.Xpath);
        public IButton MoreInfoButton => new WebElement(Driver, "//a[@class='css-14nkc1e']", Selector.Xpath);
        public IButton CloseModalButton => new WebElement(Driver, "//div[@class='css-ce9ngx']//button[@id='CloseModal']", Selector.Xpath);
        public IButton CopyrightElement => new WebElement(Driver, ".css-6kebaf", Selector.Css);

        public IButton allLITags => new WebElement(Driver, "div", Selector.TagName);


        public IButton Movie1 => new WebElement(Driver, "602211", Selector.Id);
        public IButton Movie2 => new WebElement(Driver, "//div[@id='Comedy Movies']//img[@id='551804']", Selector.Xpath);

        public string ComedyHorizontalScrollBars = "'div[class=\"css-nlgfro\"]'";

        public object getElements()
        {

            return allLITags.getElements().First(x => x.Text == "FATMAN");

        }


        public IButton RentPopUp => new WebElement(Driver, "//div[@class='notification-container--top-center']", Selector.Xpath);

        public void ScrollComedyBar()
        {
            Driver.GetElementAndScrollHorizontally(ComedyHorizontalScrollBars, 500);

        }



    }
}
