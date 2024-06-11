using Candidates.Models;
using Candidates.Tests;
using System.Globalization;

namespace Candidates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var input = new InputConsole().Input();
                var candidate = new Candidate(input);
                var resultTesting = new CheckTests().TestCandidate(candidate);
                printResults(resultTesting);
                Console.WriteLine("Если хотете протестировать еще одного кандидата нажмите \"P\", если нет - любую другую клавишу.");
                if (Console.ReadKey().Key !=  ConsoleKey.P)
                    break;
            }
            
        }
        private static void printResults(ICandidate candidate)
        {
            var acceptableCount = candidate.TestResults.Count(x => x.State == State.Acceptable);
            var unsatisfyingCount = candidate.TestResults.Count(x => x.State == State.Unsatisfying);
            if (acceptableCount > 2 || unsatisfyingCount > 0)
            {
                Console.WriteLine("Кандидат " + candidate.Name + " не прошел тестирование. Проблемы:");
                foreach (var item in candidate.TestResults)
                {
                    if(item.State != State.Accept)
                        Console.WriteLine("*" + item.Discription + (item.State == State.Acceptable? " (удовлетворительно)" : " (неудовлетворительно)"));
                }
            }
            else
                Console.WriteLine("Кандидат " + candidate.Name + " подходит");
        }
    }
}