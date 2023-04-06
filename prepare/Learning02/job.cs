using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine("{0} ({1}) {2}-{3}", _jobTitle, _company, _startYear, _endYear);
    }
}
