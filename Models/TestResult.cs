using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    internal class TestResult : ITestResult
    {
        public string Name { get; set; }
        public State State { get; set; }
        public object Value { get; set; }
        public TestType TestType { get; set; }
        public string Discription { get; set; }
    }
}
