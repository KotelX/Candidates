namespace Candidates.Models
{
    public enum State
    {
        Accept,
        Acceptable,
        Unsatisfying
    }
    public enum BadHabitsTherapist
    {
        cold,
        bronchitis,
        virus,
        allergy,
        quinsy,
        insomnia
    }
    public enum BadHabitsPsychologist
    {
        alcoholism,
        insomnia,
        narcomania,
        injury
    }
    public enum InputDataType
    {
        NotNullText,
        MoreZeroInt,
        MoreZeroLessOneDouble,
        Text
    }
    public enum InputType
    {
        Name,
        Weight,
        Height,
        Age,
        Vision,
        BadHabits
    }
    public enum TestType
    {
        Weight,
        Height,
        Age,
        Vision,
        Psychiatrist,
        Therapist,
        Smoking,
        Strange,
        Mathematical,
        WeightAndBadHabits

    }
}
