using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello world!");

        Job job1 = new Job();
        job1._company = "Lucid Software";
        job1._jobTitle = "Account Executive";
        job1._startYear = 2024;
        job1._endYear = 2027;

        // job1.display();

        Job job2 = new Job();
        job2._company = "Vanta";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // job2.display();

        Resume myResume = new Resume();
        myResume._name = "Zac Vongphakdy";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.display();
    }
}

//     public class Job
//     {
//         public string _company;
//         public string _jobTitle;
//         public int _startYear;
//         public int _endYear;
        
//          public void display()
//         {
//             Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");

//         }
//     }
// }