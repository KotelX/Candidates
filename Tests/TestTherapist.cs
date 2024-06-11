using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestTherapist : ITest
    {
        public string Name => "Терапевт";

        public TestType TestType => TestType.Therapist;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if (((List<string>)line.Value).Count > 3)
            {
                result.State = State.Unsatisfying;
                result.Discription = "У кандидата более 3 болезни(терапевт)";
            }
            if (((List<string>)line.Value).Count == 3)
            {
                result.State = State.Acceptable;
                result.Discription = "У кандидата 3 болезнь(терапевт)";
            }
            else
            {
                result.State = State.Accept;
            }

            return result;
        }
    }
}
