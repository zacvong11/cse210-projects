using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
       
        Activity running = new Running("03 Nov 2022", 30, 4.8);
        Activity cycling = new Cycling("04 Nov 2022", 45, 20.0);
        Activity swimming = new Swimming("05 Nov 2022", 60, 40);

     
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

       
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
