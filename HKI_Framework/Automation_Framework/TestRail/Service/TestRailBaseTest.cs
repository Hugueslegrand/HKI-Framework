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
using Automation_Framework.Helpers;
using Automation_Framework.TestRail.Model;
using Automation_Framework.TestRail.Service.Base.Concrete;
using Automation_Framework.TestRail.Service.Base.Entities;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;


namespace Automation_Framework.TestRail.Service
{
    public class TestRailBaseTest
    {

        private TestContext _fixtureContext;
        private TestRailApi _testRailApi;
        private string _suiteid, _projectid, _runName;
        
        private int _projectIdInt, _suiteIdInt, _caseId;
        private List<Result> _resultsForCases;

        private TestRailConfiguration testRailConfig = Configuration.TestRail;
        private bool IgnoreAddResults;
        private static int runToSave = 0;
        private static int runId;
        [OneTimeSetUp]
        public void FixtureSetup()
        {
            IgnoreAddResults = testRailConfig.ignoreAddResults;
            try
            {
                _fixtureContext = TestContext.CurrentContext;
                InitTestRailConfig();
                ValidateSuiteIdAndProjectId();
                _resultsForCases = new List<Result>();
                
                if (runToSave == 0 )
                {
                    runId = _testRailApi.CreateRun(new Run { project_id = _projectIdInt, name = _runName, suite_id = _suiteIdInt,  include_all = true });
                    runToSave = runId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IgnoreAddResults = true;
            }
        }

        [OneTimeTearDown]
        public void FixtureTearDown()
        {
            IgnoreAddResults = testRailConfig.ignoreAddResults;
            if (!IgnoreAddResults)
            {
                if (_resultsForCases.Count > 0)
                {
                  
                    if (runId > 0) _testRailApi.AddResultsForCases(runId, _resultsForCases);
                }
            }
        }

        [TearDown]
        public void Cleanup()
        {
            IgnoreAddResults = testRailConfig.ignoreAddResults;
            if (!IgnoreAddResults)
            {
                var _caseid = 0;
                var caseid = TestContext.CurrentContext.Test.Properties.Get("caseid")?.ToString();
                if (Int32.TryParse(caseid, out _caseId))
                {
                    var result = new Result { case_id = _caseId, comment = TestContext.CurrentContext.Result.Message};
                    var resultState = TestContext.CurrentContext.Result.Outcome;

                    if (resultState == ResultState.Success) result.status_id = 1;
                    else if (resultState == ResultState.Inconclusive) result.status_id = 4;
                    else result.status_id = 5;

                    _resultsForCases.Add(result);
                }
            }
        }

        private void InitTestRailConfig()
        {

            var testrailurl = testRailConfig.testrailurl;
            var username = testRailConfig.username;
            var password = testRailConfig.password;

            if (string.IsNullOrEmpty(testrailurl)) throw new Exception("Invalid testrail url");
            if (string.IsNullOrEmpty(username)) throw new Exception("Invalid testrail username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Invalid testrail password");

            _testRailApi = new TestRailApi(testrailurl, username, password);
        }

        private void ValidateSuiteIdAndProjectId()
        {
            _suiteid = _fixtureContext.Test.Properties.Get("suiteid")?.ToString();
            _projectid = _fixtureContext.Test.Properties.Get("projectid")?.ToString();
            _runName = _fixtureContext.Test.Properties.Get("runName")?.ToString();

            if (string.IsNullOrEmpty(_suiteid)) throw new Exception("Invalid suite id");
            if (string.IsNullOrEmpty(_projectid)) throw new Exception("Invalid project id");

            if (!Int32.TryParse(_projectid, out _projectIdInt)) throw new Exception("Project id not valid int");
            if (!Int32.TryParse(_suiteid, out _suiteIdInt)) throw new Exception("Suite id not valid int");

            // we should add validation for project and suite id

        }
    }
}
