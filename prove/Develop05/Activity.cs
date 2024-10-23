using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected int Duration { get; set; }

        public void StartActivity()
        {
            DisplayStartingMessage();
            Thread.Sleep(2000);
            RunActivity();
            DisplayEndingMessage();
        }

        protected abstract void RunActivity();

        private void DisplayStartingMessage()
        {
            Console.WriteLine($"Starting {GetType().Name}...");
            Console.WriteLine($"Duration: {Duration} seconds.");
            Console.WriteLine("Prepare to begin...");
        }

        private void DisplayEndingMessage()
        {
            Console.WriteLine($"Good job! You have completed the {GetType().Name}.");
            Console.WriteLine($"You spent {Duration} seconds on this activity.");
            Thread.Sleep(2000);
        }

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}