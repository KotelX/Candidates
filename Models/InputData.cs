using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class InputData
    {
        public static readonly Dictionary<int, Input> InputInfo = new Dictionary<int, Input>()
        {

            [0] = new Input() { DataType = InputDataType.NotNullText, Title = "Имя(не пустая строка):", Type = InputType.Name },
            [1] = new Input() { DataType = InputDataType.MoreZeroInt, Title = "Вес(целое число, больше 0):", Type = InputType.Weight },
            [2] = new Input() { DataType = InputDataType.MoreZeroInt, Title = "Рост(целое число, больше 0):", Type = InputType.Height },
            [3] = new Input() { DataType = InputDataType.MoreZeroInt, Title = "Возраст(целое число, больше 0):", Type = InputType.Age },
            [4] = new Input() { DataType = InputDataType.MoreZeroLessOneDouble, Title = "Зрение(дробное число, от 0 до 1):", Type = InputType.Vision },
            [5] = new Input() { DataType = InputDataType.Text, Title = "Вредные привычки(разделенные пробелами):", Type = InputType.BadHabits }
        };
    }
    public class Input
    {
        public string Title { get; set; }
        public InputType Type { get; set; }
        public InputDataType DataType { get; set; }
        public string Value { get; set; }
    }

    public class BadHabits
    {
        public static readonly List<string> BadHabitsTherapist = new List<string>() 
        {
            "cold",
            "bronchitis",
            "virus",
            "allergy",
            "quinsy",
            "insomnia"
        };
        public static readonly List<string> BadHabitsPsychologist = new List<string>()
        {
            "alcoholism",
            "insomnia",
            "narcomania",
            "injury"
        };
        public static readonly List<string> BadHabitsAnother = new List<string>()
        {
            "smoking"
        };
    }
}
