using System;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activity
    {
        private static readonly string[] Prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static readonly string[] Questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind for the future?"
        };

        public ReflectionActivity(int duration)
        {
            Duration = duration;
        }

        protected override void RunActivity()
        {
            Random rand = new Random();
            Console.WriteLine("This activity will help you reflect on times when you have shown strength.");
            Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
            
            int secondsRemaining = Duration;

            while (secondsRemaining > 0)
            {
                Console.WriteLine(Questions[rand.Next(Questions.Length)]);
                Countdown(5);
                secondsRemaining -= 5;
            }
        }
    }
}
