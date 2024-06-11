using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public interface ITest
    {
        string Name { get; }
        TestType TestType { get; }
        ITestResult StartTest(ICandidate candidate);
    }
}
