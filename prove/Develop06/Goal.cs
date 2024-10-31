namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public bool IsComplete { get; set; }

        protected Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
            IsComplete = false;
        }

        public abstract int RecordProgress();
        public abstract string DisplayStatus();
        public abstract string SaveFormat();
    }
}
