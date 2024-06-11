using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Tests
{
    class CheckTests
    {
        public ICandidate TestCandidate(ICandidate candidate)
        {
            List<ITest> tests = new List<ITest>()
            {
                new TestsWeight(),
                new TestHeight(),
                new TestAge(),
                new TestVision(),
                new TestSmoking(),
                new TestTherapist(),
                new TestPsychiatrist(),
                new TestWeightAndBadHabits(),
                new TestStrange(),
                new TestMathematical()
            };

            foreach (var item in tests)
            {
                var testResults = candidate.TestResults.FirstOrDefault(x => x.TestType == item.TestType);
                if (testResults == null) 
                {
                    candidate.TestResults.Add(new TestResult() { TestType = item.TestType });
                    testResults = candidate.TestResults.FirstOrDefault(x => x.TestType == item.TestType);
                }
                var res = item.StartTest(candidate);
                testResults.State = res.State;
                testResults.Discription = res.Discription;
            }
            return candidate;
        }
    }
}
