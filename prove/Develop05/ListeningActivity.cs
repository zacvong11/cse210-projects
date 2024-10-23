using System;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private static readonly string[] Prompts = {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity(int duration)
        {
            Duration = duration;
        }

        protected override void RunActivity()
        {
            Random rand = new Random();
            Console.WriteLine("This activity will help you list the positive things in your life.");
            Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
            
            Countdown(5); 
            Console.WriteLine("Start listing items...");

            int itemsCount = 0;
            int secondsRemaining = Duration;

            while (secondsRemaining > 0)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    itemsCount++;
                }
                secondsRemaining -= 5;
            }

            Console.WriteLine($"You listed {itemsCount} items.");
        }
    }
}