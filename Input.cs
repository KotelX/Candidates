using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    public class InputConsole
    {
        public Dictionary<int, Input> Input()
        {
            var result = new Dictionary<int, Input>();
            Console.WriteLine("Введите данные кандидата:");
            foreach (var line in InputData.InputInfo)
            {
                string input;
                do
                {
                    Console.WriteLine(line.Value.Title);
                    input = Console.ReadLine();
                } while(!CheckInput(input, line.Value.DataType));
                line.Value.Value = input;
                result.Add(line.Key, line.Value);
            }
            return result;
        }
        private bool CheckInput(string input, InputDataType type)
        {
            switch (type)
            {
                case InputDataType.NotNullText:
                    return !string.IsNullOrEmpty(input);
                case InputDataType.Text:
                    var s = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault(x => BadHabits.BadHabitsTherapist.FirstOrDefault(y => y == x) == default && BadHabits.BadHabitsPsychologist.FirstOrDefault(y => y == x) == default && BadHabits.BadHabitsAnother.FirstOrDefault(y => y == x) == default);
                    if (!string.IsNullOrWhiteSpace(s))
                    {
                        Console.WriteLine(s + " не найдено такой вредной привычки.");
                        return false;
                    }
                    else
                        return true;
                case InputDataType.MoreZeroLessOneDouble:
                    return double.TryParse(input, out double a) == false ? false : (a <= 1 && a > 0);
                case InputDataType.MoreZeroInt:
                    return int.TryParse(input, out int b) == false ? false : (b > 0);
                default: return false;
            }
        }
    }
}
