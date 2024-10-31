using System;
// 
namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nEternal Quest Program");
                Console.WriteLine("1 - Create New Goal");
                Console.WriteLine("2 - List Goals");
                Console.WriteLine("3 - Save Goals");
                Console.WriteLine("4 - Load Goals");
                Console.WriteLine("5 - Record Event");
                Console.WriteLine("6 - Quit");
                // made it so that the user can see their points in the menu, these points will also save and load like everything else
                Console.WriteLine($"Total Points: {user.Score}");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        user.CreateGoal();
                        break;
                    case "2":
                        user.ListGoals();
                        break;
                    case "3":
                        Console.Write("What is the filename for these goals? ");
                        string saveFilename = Console.ReadLine();
                        user.SaveGoals(saveFilename);
                        break;
                    case "4":
                        Console.Write("What is the filename to load goals from? ");
                        string loadFilename = Console.ReadLine();
                        user.LoadGoals(loadFilename);
                        break;
                    case "5":
                        user.RecordEvent();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
