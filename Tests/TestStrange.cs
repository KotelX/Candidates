using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestStrange : ITest
    {
        public string Name => "Тест «Странный»";

        public TestType TestType => TestType.Strange;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if (candidate.Name[0] == 'П')
            {
                result.State = State.Accept;
            }
            else
            {
                if((uint)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Age).Value > 68)
                {
                    result.State = State.Acceptable;
                    result.Discription = "Имя кандидата не начинается с буквы «П» и возраст кандидата больше 68 лет";
                }
                else
                {
                    result.State = State.Unsatisfying;
                    result.Discription = "Имя кандидата не начинается с буквы «П» и возраст кандидата меньше или равно 68 лет";
                }
            }
            return result;
        }
    }
}
