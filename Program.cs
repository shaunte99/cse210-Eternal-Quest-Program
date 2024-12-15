using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            var goalTracker = new GoalTracker();

            Console.WriteLine("Welcome to Eternal Quest!");
            string choice = "";

            while (choice != "6")
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. Display goals");
                Console.WriteLine("3. Record progress");
                Console.WriteLine("4. Save goals");
                Console.WriteLine("5. Load goals");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        goalTracker.CreateGoal();
                        break;
                    case "2":
                        goalTracker.DisplayGoals();
                        break;
                    case "3":
                        goalTracker.RecordProgress();
                        break;
                    case "4":
                        goalTracker.SaveProgress("progress.txt");
                        break;
                    case "5":
                        goalTracker.LoadProgress("progress.txt");
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
