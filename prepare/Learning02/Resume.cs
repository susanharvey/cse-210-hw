using System;

// declare Resume class, attribute name
public class Resume
{
    public string _name = "";

    //initialize list to new list
    public List<Job> _jobsList = new List<Job>();

    //class Resume method
    public void DisplayJobsList()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write("Jobs: ");

        //foreach loop to iterate through list
        //custom data type "Job"
        foreach (Job j in _jobsList)
        {
            //calls DispayJobInfo on each job
            j.DisplayJobInfo();
        }  
    }
}