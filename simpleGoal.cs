namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void RecordProgress()
        {
            if (!IsCompleted)
            {
                IsCompleted = true;
                Console.WriteLine($"Completed {Name} and earned {Points} points!");
            }
            else
            {
                Console.WriteLine($"Goal {Name} already completed.");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"{GetStatus()} {Name} - {Points} points");
        }

        public override string GetStatus()
        {
            return IsCompleted ? "[X]" : "[ ]";
        }
    }
}
