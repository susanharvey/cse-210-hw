using System;

class Program
{
    static void Main(string[] args)
    {
        //Declare and initialize new _activiies list
        List<Activity> _activities = new();


        //Declare and initialize new running activity
        //add running activity to the _activities list
        Running running = new("Running", "05 May 2024", 30, 3.3 );
        _activities.Add(running);


        //Declare and initialize new swimming activity
        //add swimming activity to the _activities list
        Swimming swimming = new("Swimming", "22 April 2023", 20, 8.5 );
        _activities.Add(swimming);


        //Declare and initialize new stationaryBicycle activity
        //add stationaryBicycle activity to the _activities list
        StationaryBicycles stationaryBicycle = new("StationaryBicycles", "01 June, 2024", 10, 10.45);
        _activities.Add(stationaryBicycle);


        //Foreach loop, condition: for each activity in _activities
        foreach (Activity activity in _activities)
        {
            //Display the activity's summary
            //by calling the GetSummary methodS
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}