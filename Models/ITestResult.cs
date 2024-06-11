using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public interface ITestResult
    {
        public string Name { get; set; }
        public State State { get; set; }
        public TestType TestType { get; set; }
        public string Discription { get; set; }
        public object Value { get; set; }
    }
}
