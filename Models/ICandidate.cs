using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public interface ICandidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ITestResult> TestResults { get; set; }
    }
}
