/**
 * TestRail integration
 *
 * Learn more:
 *
 * https://github.com/AshleyDhevalall/TestRail.NUnit.Integration
 * 
 *
 * Copyright (c) 2019 AshleyDhevalall. See license.md for details.
 */
namespace Automation_Framework.TestRail.Model
{
    public class TestRailConfiguration
    {
        public string testrailurl { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool ignoreAddResults { get; set; }
    }
}
