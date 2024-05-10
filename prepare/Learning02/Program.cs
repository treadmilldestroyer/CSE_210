using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Salesforce";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2000;
        job2._endYear = 2010;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();


        Resume resume = new Resume();
        resume._jobList.Add(job1);
        resume._jobList.Add(job2);
        resume._name = "Allison Rose";

        resume.DisplayResumeDetails();



    }
}