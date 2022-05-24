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
    public class Result
    {
        public int case_id { get; set; }
        public int status_id { get; set; }
        public string comment { get; set; }
        public string defects { get; set; }
        public string elapsed { get; set; }
        public string version { get; set; }
        public int? assignedto_id { get; set; }
    }
}
