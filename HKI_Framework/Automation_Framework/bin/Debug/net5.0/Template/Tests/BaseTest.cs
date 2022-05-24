using Automation_Framework.Builders;
using Automation_Framework.Base;
using Automation_Framework.Enums;
using Automation_Framework.Models;
using Automation_Framework.Utilities;
using Automation_Framework.TestRail.Service;
using Automation_Framework.Tests.Pages;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Automation_Framework.Tests.Tests
{
    [TestFixture]
    [AllureNUnit]
    [Property("runName", "Template run")] //RUN NAME for TestRail
    [Property("suiteid", "1")] //Suite ID in TestRail
    [Property("projectid", "1")]//Project ID in TestRail
    public class BaseTest : TestRailBaseTest //Implement testRail in case you want to send reports to testRail
    {

        public DriverBuilder builder = new DriverBuilder();


        [SetUp]
        public void Setup()
        {
            builder.BuildDriver(PlatformType.Desktop);// Build a driver of choice
            //builder.BuildDriver(PlatformType.Android);
            //builder.BuildDriver(PlatformType.IOS);
            //builder.BuildDriver(PlatformType.WebAndroid);
            //builder.BuildDriver(PlatformType.WebIOS);;
            Log.StartTestCase((string)TestContext.CurrentContext.Test.Properties.Get("Description"));
  
        }

        [TearDown]
        public void TearDown()
        {

            builder.CloseDriver(PlatformType.Desktop);// Close a driver of choice
            Log.EndTestCase(TestContext.CurrentContext.Result.Message);
        }

    }
}
