using System;

class Program
{
    static void Main(string[] args)
    {
        Person student1 = new Person();
        student1.Name = "Pelin";
        student1.Surname = "Başaslan";
        student1.BirthDay = new DateTime(1996, 08, 14);

        Person student2 = new Person();
        student2.Name = "John";
        student2.Surname = "Doe";
        student2.BirthDay = new DateTime(1950, 12, 12);

        Person teacher = new Person();
        teacher.Name = "Jane";
        teacher.Surname = "Doe";
        teacher.BirthDay = new DateTime(1996, 01, 01);

        teacher.DisplayInfo();
        student1.DisplayInfo();
        student2.DisplayInfo();

    }
}