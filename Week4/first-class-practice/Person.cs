using System;
public class Person
{
    private string name;
    private string surname;

    private DateTime birthDay;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public DateTime BirthDay
    {
        get { return birthDay; }
        set { birthDay = value; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Adı soyadı {name} {surname}, Doğum tarihi {birthDay}");
    }


}