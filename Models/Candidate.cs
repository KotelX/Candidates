using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    internal class Candidate : ICandidate
    {
        public Candidate(Dictionary<int, Input> inputData)
        {
            foreach (var value in inputData)
            {
                switch (value.Value.Type)
                {
                    case InputType.Name:
                        Name = value.Value.Value;
                        break;
                    case InputType.Weight:
                        TestResults.Add(new TestResult() { TestType = TestType.Weight, Value = uint.Parse(value.Value.Value) });
                        break;
                    case InputType.Height:
                        TestResults.Add(new TestResult() { TestType = TestType.Height, Value = uint.Parse(value.Value.Value) });
                        break;
                    case InputType.Age:
                        TestResults.Add(new TestResult() { TestType = TestType.Age, Value = uint.Parse(value.Value.Value) });
                        break;
                    case InputType.Vision:
                        TestResults.Add(new TestResult() { TestType = TestType.Vision, Value = double.Parse(value.Value.Value) });
                        break;
                    case InputType.BadHabits:
                        var s = value.Value.Value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        TestResults.Add(new TestResult() { TestType = TestType.Smoking, Value = s.FirstOrDefault(x => x == "smoking") != default });
                        var tList = new List<string>();
                        var pList = new List<string>();
                        foreach (var v in s)
                        {
                            if (BadHabits.BadHabitsTherapist.FirstOrDefault(x => x == v) != null)
                                tList.Add(v);
                            if (BadHabits.BadHabitsPsychologist.FirstOrDefault(x => x == v) != null)
                                pList.Add(v);
                        }
                        TestResults.Add(new TestResult() { TestType = TestType.Therapist, Value = tList });
                        TestResults.Add(new TestResult() { TestType = TestType.Psychiatrist, Value = pList });
                        break;
                }
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ITestResult> TestResults { get; set; } = new List<ITestResult>();
    }
}
