using LiveTue;

public class Sahip
{
    private List<BaseHayvan> _hayvanlar = new List<BaseHayvan>();

    public void HayvanEkle(BaseHayvan hayvan)
    {
        _hayvanlar.Add(hayvan);
        Console.WriteLine($"{hayvan.Ad} sahiplenildi.");
    }

    public void HayvanlariListele()
    {
        Console.WriteLine("Sahip olunan hayvanlar:");
        foreach (var hayvan in _hayvanlar)
        {
            Console.WriteLine(hayvan.Ad);
        }
    }

}