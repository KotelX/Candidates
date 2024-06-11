using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestSmoking : ITest
    {
        public string Name => "Курение";

        public TestType TestType => TestType.Smoking;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if ((bool)line.Value)
            {
                result.State = State.Unsatisfying;
                result.Discription = "Кандидат курит";
            }
            
            return result;
        }
    }
}
