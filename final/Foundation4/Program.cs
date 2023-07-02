using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create activity objects
        RunningActivity runningActivity = new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0);
        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2022, 11, 3), 30, 12);
        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2022, 11, 3), 30, 20);

        // Add activities to the list
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}