namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        public int TimesRequired { get; set; }
        public int TimesCompleted { get; set; }
        public int BonusPoints { get; set; }

        public ChecklistGoal(string name, int points, int timesRequired, int bonusPoints) 
            : base(name, points)
        {
            TimesRequired = timesRequired;
            BonusPoints = bonusPoints;
            TimesCompleted = 0;
        }

        public override void RecordProgress()
        {
            if (TimesCompleted < TimesRequired)
            {
                TimesCompleted++;
                Console.WriteLine($"You have completed {Name} {TimesCompleted}/{TimesRequired} times.");
            }
            else
            {
                Console.WriteLine($"Goal {Name} is already fully completed.");
            }
        }

        public override void Display()
        {
            Console.WriteLine($"{GetStatus()} {Name} - {Points} points - {TimesCompleted}/{TimesRequired} completed - Bonus: {BonusPoints} points");
        }

        public override string GetStatus()
        {
            return TimesCompleted >= TimesRequired ? "[X]" : "[ ]";
        }
    }
}
