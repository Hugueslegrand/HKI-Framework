using Automation_Framework.Tests.Pages;
using NUnit.Framework;
using FluentAssertions;
using Automation_Framework.Tests.Models;


namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
 
    public class TestKeyboardShortcuts : BaseTest
    {
        User userAdminExist = new("John.Doe@example.be", "johnDoe123");

        [Test, Property("caseid", "1")]// Case ID in TestRail
        [Description("Login as an existing user only using keyboard")]
        public void Test_KeyboardShortcuts()
        {
            Navigation navigation = new Navigation(builder);
            navigation.WaitSeconds(6);
            navigation.JavascriptExecutor("document.body.style.transform='scale(0.99, 0.99)'");
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressEnter();

            LoginPage loginPage = new LoginPage(builder);
            loginPage.Should();
            navigation.PressTab();
            navigation.PressTab();
            navigation.PressTab();
            loginPage.PressTab();
            loginPage.SignInEmail.SendKeys(userAdminExist.email);
            loginPage.PressEnter();
            loginPage.SignInPassword.SendKeys(userAdminExist.password);
            loginPage.PressEnter();
            navigation.SignOutButton.Should();
            navigation.MyMovieButton.Should();
            navigation.ProfileButton.Should();

        }
    }
}
