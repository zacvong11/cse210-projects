using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    break;
                }

                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());

                Activity activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity(duration);
                        break;
                    case "2":
                        activity = new ReflectionActivity(duration);
                        break;
                    case "3":
                        activity = new ListingActivity(duration);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }

                activity.StartActivity();
            }
        }
    }
}
