namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points) { }

        public override int RecordProgress()
        {
            return Points;
        }

        public override string DisplayStatus()
        // made it so that eternal goals show an infinity sign
        {
            return $"[∞] {Name} ({Description})";
        }

        public override string SaveFormat()
        {
            return $"EternalGoal|{Name}|{Description}|{Points}|{IsComplete}";
        }
    }
}
