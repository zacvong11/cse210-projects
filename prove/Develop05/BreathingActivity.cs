using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(int duration)
        {
            Duration = duration;
        }

        protected override void RunActivity()
        {
            Console.WriteLine("This activity will help you relax by guiding you through breathing in and out slowly.");
            int secondsRemaining = Duration;

            while (secondsRemaining > 0)
            {
                Console.WriteLine("Breathe in...");
                Countdown(3);
                Console.WriteLine("Breathe out...");
                Countdown(3); 
                secondsRemaining -= 6;
            }
        }
    }
}
