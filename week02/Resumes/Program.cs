using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Deloitte";
        job1._jobTitle = "Senior Auditor";
        job1._startYear = 2011;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._company = "Tech Solutions Inc.";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2023;
        Console.WriteLine($"My Job History: {job1._company}");
        Console.WriteLine($"              : {job2._company}");

        Resume resume = new Resume();
        resume._name = "Jonathan Gomez";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }

}