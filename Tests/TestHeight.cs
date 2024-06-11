using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestHeight : ITest
    {
        public string Name => "Рост";

        public TestType TestType => TestType.Height;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            result.Name = Name;
            if ((uint)line.Value >= 190)
            {
                result.State = State.Unsatisfying;
                result.Discription = "Рост кандидата больше 190см";
            }else
            if ((uint)line.Value >= 185)
            {
                result.State = State.Acceptable;
                result.Discription = "Рост кандидата больше 185см";
            }
            else
            if ((uint)line.Value >= 170)
            {
                result.State = State.Accept;
                result.Discription = "";
            }
            else
            if ((uint)line.Value >= 160)
            {
                result.State = State.Acceptable;
                result.Discription = "Рост кандидата меньше 170см";
            }
            else
            {
                result.State = State.Unsatisfying;
                result.Discription = "Рост кандидата меньше 160см";
            }
            return result;
        }
    }
}
