using System;
//create class Job
public class Job 
{
    //create fields
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        //Call fields
        Console.WriteLine($"{_jobTitle}, {_companyName}, {_startYear}-{_endYear}. ");
    }
}