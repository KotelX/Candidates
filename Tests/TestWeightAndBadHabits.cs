using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    internal class TestWeightAndBadHabits : ITest
    {
        public string Name => "Тест «Вес и вредные привычки»";

        public TestType TestType => TestType.WeightAndBadHabits;

        public ITestResult StartTest(ICandidate candidate)
        {
            var line = candidate.TestResults.FirstOrDefault(x => x.TestType == TestType);
            var result = line;
            if ((bool)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Smoking).Value 
                && ((List<string>)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Therapist).Value).FirstOrDefault(x => x == "cold" || x == "virus") != null 
                && ((uint)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Weight).Value > 120 || ((uint)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Weight).Value < 60))) 
            {
                result.State = State.Unsatisfying;
                result.Discription = "Кандидат курит, у кандидата простуда и/или вирусы, и его вес" + ((uint)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Weight).Value > 120? " больше 120 кг" :" меньше 60 кг");
            }
            else
            {
                if (((List<string>)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Therapist).Value).FirstOrDefault(x => x == "cold" || x == "virus") != null && (uint)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Weight).Value > 110)
                    result.Discription = (bool)candidate.TestResults.FirstOrDefault(x => x.TestType == TestType.Smoking).Value ? "Кандидат курит и " : "" + "у кандидата есть простуда и/или вирусы, и его вес больше 110 кг";
                else
                    result.State = State.Accept;
            }
            return result;
        }
    }
}
