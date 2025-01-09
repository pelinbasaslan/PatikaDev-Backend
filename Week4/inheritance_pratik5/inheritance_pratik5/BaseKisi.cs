public class BaseKisi
{
    public string Name { get; set; }
    public string SurName { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Kişinin Adı:{Name}, Soyadı:{SurName}.");
    }

}

public class Ogrenci : BaseKisi
{
    public string StudentNumber { get; set; }

    public void DisplayInfoOgrenci()
    {
        DisplayInfo();
        Console.WriteLine($"Öğrenci numarası:{StudentNumber}");
    }
}

public class Ogretmen : BaseKisi
{
    public decimal Wage { get; set; }

    public void DisplayInfoOgretmen()
    {
        DisplayInfo();
        Console.WriteLine($"Maaşı: {Wage}");
    }
}