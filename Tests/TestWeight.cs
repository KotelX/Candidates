using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Tests
{
    internal class TestsWeight : ITest
    {
        public string Name => "Вес";

        public TestType TestType => TestType.Weight;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if ((uint)line.Value >= 100)
            {
                result.State = State.Unsatisfying;
                result.Discription = "Вес кандидата больше 100кг";
            }
            else
            if ((uint)line.Value >= 90)
            {
                result.State = State.Acceptable;
                result.Discription = "Вес кандидата больше 90кг";
            }
            else
            if ((uint)line.Value >= 75)
            {
                result.State = State.Accept;
                result.Discription = "";
            }
            else
            if ((uint)line.Value >= 70)
            {
                result.State = State.Acceptable;
                result.Discription = "Вес кандидата меньше 75кг";
            }
            else
            {
                result.State = State.Unsatisfying;
                result.Discription = "Вес кандидата меньше 70кг";
            }
            return result;
        }
    }
}
