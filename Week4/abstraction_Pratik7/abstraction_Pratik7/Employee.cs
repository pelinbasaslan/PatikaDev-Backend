public abstract class Employee //hem soyut hem somut içerir
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string Departmant { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Selamlar. Ben {Name} {SurName}. {Departmant} departmanında,");
    }
    public abstract void Task(); //soyut 

}

public class ProjectManager : Employee
{
    public ProjectManager(string name, string surName, string departmant)
    {
        Name = name;
        SurName = surName;
        Departmant = departmant;
    }

    public override void Task()
    {
        Console.WriteLine("proje yöneticisi olarak çalışıyorum.");
    }
}

public class SoftwareDeveloper : Employee
{
    public SoftwareDeveloper(string name, string surName, string departmant)
    {
        Name = name;
        SurName = surName;
        Departmant = departmant;
    }

    public override void Task()
    {
        Console.WriteLine("yazılım geliştirici olarak çalışıyorum.");
    }
}

public class SalesRepresentative : Employee
{
    public SalesRepresentative(string name, string surName, string departmant)
    {
        Name = name;
        SurName = surName;
        Departmant = departmant;
    }
    public override void Task()
    {
        Console.WriteLine("satış temsilcisi olarak çalışıyorum.");
    }
}