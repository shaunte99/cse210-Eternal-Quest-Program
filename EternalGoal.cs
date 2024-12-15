namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public int TimesCompleted { get; set; }

        public EternalGoal(string name, int points) : base(name, points) { }

        public override void RecordProgress()
        {
            TimesCompleted++;
            Console.WriteLine($"You have completed {Name} {TimesCompleted} times.");
        }

        public override void Display()
        {
            Console.WriteLine($"{GetStatus()} {Name} - {Points} points - {TimesCompleted} times completed.");
        }

        public override string GetStatus()
        {
            return IsCompleted ? "[X]" : "[ ]";
        }
    }
}
