// EXAMPLE FROM READING


// public class Person
// {
//     public string _givenName = "";
//     public string _familyName = "";


//     public Person()
//     {
//     }


//     public void ShowEasternName()
//     {
//         Console.WriteLine($"{_familyName}, {_givenName}");
//     }


//     public void ShowWesternName()
//     {
//         Console.WriteLine($"{_givenName} {_familyName}");
//     }
// }



public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;



    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }



}