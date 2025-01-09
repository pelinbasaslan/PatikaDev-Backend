using System.Reflection.Metadata.Ecma335;

public class Bebek
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDay { get; set; }

    public Bebek()
    {
        Console.WriteLine("Ingaaa");
        BirthDay = DateTime.Now;
    }

    public Bebek(string name, string surname)
    {
        Name = name;
        Surname = surname;
        Console.WriteLine("Ingaaa");
        BirthDay = DateTime.Now;
    }

    public void BebekKendiniTanitiyor()
    {
        Console.WriteLine($"Selamlar. Benim adım: {Name} Soyadım: {Surname}. Sen bebek nesnesini newlediğin anda doğdum ve bu tarih :{BirthDay}");
    }

}
