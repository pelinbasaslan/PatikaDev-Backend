using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Türkçe" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };

        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "A", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "B", ClassId = 2 },
            new Student { StudentId = 3, StudentName = "C", ClassId = 1 },
            new Student { StudentId = 4, StudentName = "D", ClassId = 3 },
            new Student { StudentId = 5, StudentName = "F", ClassId = 2 }
        };


        var result = from cls in classes
                     join std in students on cls.ClassId equals std.ClassId into studentGroup
                     select new
                     {
                         ClassName = cls.ClassName,
                         Students = studentGroup
                     };


        foreach (var item in result)
        {
            Console.WriteLine($"Class: {item.ClassName}");
            foreach (var student in item.Students)
            {
                Console.WriteLine($"  - {student.StudentName}");
            }
            Console.WriteLine();
        }
    }
}

class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int ClassId { get; set; }
}

class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
}