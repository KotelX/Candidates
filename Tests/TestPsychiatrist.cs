using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestPsychiatrist : ITest
    {
        public string Name => "Терапевт";

        public TestType TestType => TestType.Psychiatrist;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if (((List<string>)line.Value).Count > 1)
            {
                result.State = State.Unsatisfying;
                result.Discription = "У кандидата более 1 болезни(психолог)";
            }
            if (((List<string>)line.Value).Count == 1)
            {
                result.State = State.Acceptable;
                result.Discription = "У кандидата 1 болезнь(психолог)";
            }
            else
            {
                result.State = State.Accept;
            }

            return result;
        }
    }
}
