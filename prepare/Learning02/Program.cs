using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume()
        {
            _name = "Allison Rose",
            _jobs = new List<Job>()
            {
                new Job()
                {
                    _jobTitle = "Software Engineer",
                    _company = "Microsoft",
                    _startYear = 2019,
                    _endYear = 2022
                },
                new Job()
                {
                    _jobTitle = "Manager",
                    _company = "Apple",
                    _startYear = 2022,
                    _endYear = 2023
                }
            }
        };

        myResume.Display();
    }
}
