using System;

class Program
{
    static void Main(string[] args)
    {
        // initialize job1, job1 instances
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // initialize job2, job2 instances
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job1.DisplayJobInfo();
        //job2.DisplayJobInfo();

       //initialize resume, resume instances
        Resume resume = new Resume();
        resume._name = "Allison Rose";
        
       // add job1 and job2 to _jobsList
        resume._jobsList.Add(job1);
        resume._jobsList.Add(job2);

        //Call resume DisplayJobs List method
        resume.DisplayJobsList();   
    } 
}