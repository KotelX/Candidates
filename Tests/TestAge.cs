using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestAge : ITest
    {
        public string Name => "Возраст";
        public TestType TestType => TestType.Age;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if ((uint)line.Value >= 37)
            {
                result.State = State.Unsatisfying;
                result.Discription = "Возраст кандидата больше 37лет";
            }else
            if ((uint)line.Value >= 35)
            {
                result.State = State.Acceptable;
                result.Discription = "Возраст кандидата больше 35лет";
            }
            else
            if ((uint)line.Value >= 25)
            {
                result.State = State.Accept;
                result.Discription = "";
            }
            else
            if ((uint)line.Value >= 23)
            {
                result.State = State.Acceptable;
                result.Discription = "Возраст кандидата меньше 25лет";
            }
            else
            {
                result.State = State.Unsatisfying;
                result.Discription = "Возраст кандидата меньше 23лет";
            }
            return result;
        }
    }
}
