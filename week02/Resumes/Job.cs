using System;

public class Job
{
    public string _jobTitle = "Software Engineer";
    public string _company = "Tech Company";
    public int _startYear;
    public int _endYear;

    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}