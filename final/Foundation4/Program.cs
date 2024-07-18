using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Run runActivity = new Run("03/10/25", "Running", 30, 3.1);
        Bike bikeActivity = new Bike("04/16/25", "Biking", 60, 12.5);
        Swim swimActivity = new Swim("07/07/25", "Swimming", 40, 12);

        activities.Add(runActivity);
        activities.Add(bikeActivity);
        activities.Add(swimActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}