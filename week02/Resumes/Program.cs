using System;

public class Job
{
    string _jobTitle = "Software Engineer";
    string _company = "Tech Company";
    string _firstName;

    string _lastName;

    int _startYear = 2020;
    int _endYear = 2023;

    public Job()
    {
        Console.Write("First Name: ");
        _firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        _lastName = Console.ReadLine();

        Console.WriteLine($"Name: {_firstName} {_lastName}"); //n: l c
        Console.WriteLine($"Jobs:"); // j:
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}"); // se (m) 19-22
    }
}