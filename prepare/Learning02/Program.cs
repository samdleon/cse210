using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company = "Brigham Young University-Idaho";
        job1._jobTitle = "Tutor";
        job1._startYear = 2024;
        job1._endYear = 2026;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Church of Jesus Christ of Latter-Day Saints";
        job2._jobTitle = "Temple Ordinance Recorder";
        job2._startYear = 2023;
        job2._endYear = 2025;
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Sam Leon";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();








    }
}