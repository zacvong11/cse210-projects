namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points) { }

        public override int RecordProgress()
        {
            if (!IsComplete)
            {
                IsComplete = true;
                return Points;
            }
            return 0;
        }

        public override string DisplayStatus()
        {
            string status = IsComplete ? "[X]" : "[ ]";
            return $"{status} {Name} ({Description})";
        }

        public override string SaveFormat()
        {
            return $"SimpleGoal|{Name}|{Description}|{Points}|{IsComplete}";
        }
    }
}
