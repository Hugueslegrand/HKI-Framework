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

namespace Automation_Framework.TestRail.Service.Base.Entities
{
    public class Suite
    {
        public string description { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int project_id { get; set; }
        public string url { get; set; }
    }
}
