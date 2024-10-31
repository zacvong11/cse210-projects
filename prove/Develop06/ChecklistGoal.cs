namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        public int RequiredCompletions { get; private set; }
        public int CurrentCompletions { get; set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(string name, string description, int points, int requiredCompletions, int bonusPoints)
            : base(name, description, points)
        {
            RequiredCompletions = requiredCompletions;
            BonusPoints = bonusPoints;
            CurrentCompletions = 0;
        }

        public override int RecordProgress()
        {
            if (!IsComplete)
            {
                CurrentCompletions++;
                if (CurrentCompletions >= RequiredCompletions)
                {
                    IsComplete = true;
                    return Points + BonusPoints;
                }
                return Points;
            }
            return 0;
        }

        public override string DisplayStatus()
        {
            string status = IsComplete ? "[X]" : "[ ]";
            return $"{status} {Name} ({Description}) -- Currently completed: {CurrentCompletions}/{RequiredCompletions}";
        }

        public override string SaveFormat()
        {
            return $"ChecklistGoal|{Name}|{Description}|{Points}|{IsComplete}|{RequiredCompletions}|{CurrentCompletions}|{BonusPoints}";
        }
    }
}
