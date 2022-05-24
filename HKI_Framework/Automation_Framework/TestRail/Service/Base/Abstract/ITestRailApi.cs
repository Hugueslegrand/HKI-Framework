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
using Automation_Framework.TestRail.Service.Base.Entities;
using System.Collections.Generic;


namespace Automation_Framework.TestRail.Service.Base.Abstract
{
    public interface ITestRailApi
    {
        int CreateRun(Run run);
        void AddResultsForCases(int runId, List<Result> results);
    }
}
