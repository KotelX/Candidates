using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestMathematical : ITest
    {
        public string Name => "Возраст";

        public TestType TestType => TestType.Mathematical;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if ((uint)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Height).Value % 3 == 0 && ((List<string>)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Therapist).Value).FirstOrDefault(x => x == "cold") != null)
            {
                result.State = State.Unsatisfying;
                result.Discription = "Рост делится нацело на 3, и у кандидата насморк";
            }
            else
            {
                if((uint)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Height).Value % 2 == 0)
                {
                    result.State = State.Accept;
                }
                else
                {
                    result.State = State.Acceptable;
                    result.Discription = "Рост кандидата не делица нацело на 2 и " + ((uint)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Height).Value % 3 == 0? "у кандидата нет насморка ": "рост кандидата не делица нецело на 3");
                }
            }
            return result;
        }
    }
}
