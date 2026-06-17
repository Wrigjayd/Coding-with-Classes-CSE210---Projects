using System;

class Program
{
    static void Main(string[] args)
    {
            List<Activity> activities = new List<Activity>();
            activities.Add(new RunningActivity("03 Nov 2022", 30, 4.8));
            activities.Add(new StationaryBicyclesActivity("04 Nov 2022", 45, 20.0));
            activities.Add(new SwimmingActivity("05 Nov 2022", 20, 20));
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
    }
}