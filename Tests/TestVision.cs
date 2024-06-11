using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestVision : ITest
    {
        public string Name => "Зрение";

        public TestType TestType => TestType.Vision;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if ((double)line.Value < 1)
            {
                result.State = State.Unsatisfying;
                result.Discription = "Зрение кандидата меньше 1";
            }
            else
                result.State = State.Accept;
            return result;
        }
    }
}
