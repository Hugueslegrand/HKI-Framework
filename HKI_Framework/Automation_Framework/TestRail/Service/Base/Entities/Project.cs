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
    public class Project
    {
        public string announcement { get; set; }
        public object completed_on { get; set; }
        public int id { get; set; }
        public bool is_completed { get; set; }
        public string name { get; set; }
        public bool show_announcement { get; set; }
        public string url { get; set; }
    }
}
