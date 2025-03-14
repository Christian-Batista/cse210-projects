using System;
using JobNameSpace;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Job class
        Job job = new Job();
        // Set the values of the properties
        job._jobTitle = "Software Engineer";
        job._company = "Microsoft";
        job._startYear = 2019;
        job._endYear = 2022;
        // Call the Display method
        job.Display();
    }
}