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

using System.Collections.Generic;

namespace Automation_Framework.TestRail.Service.Base.Entities
{
    public class Case
    {
        public int created_by { get; set; }
        public int created_on { get; set; }
        public string custom_expected { get; set; }
        public string custom_preconds { get; set; }
        public string custom_steps { get; set; }
        public List<CustomStepsSeparated> custom_steps_separated { get; set; }
        public string estimate { get; set; }
        public object estimate_forecast { get; set; }
        public int id { get; set; }
        public int milestone_id { get; set; }
        public int priority_id { get; set; }
        public string refs { get; set; }
        public int section_id { get; set; }
        public int suite_id { get; set; }
        public string title { get; set; }
        public int type_id { get; set; }
        public int updated_by { get; set; }
        public int updated_on { get; set; }
    }
}
