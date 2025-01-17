using LiveTue;

public abstract class BaseHayvan : IHayvan
{
    public string Ad { get; set; }
    public string Tur { get; set; }
    public BaseHayvan()
    {
        Console.WriteLine("Hayvan constructor tetiklendi.");
    }

    public abstract void SesCıkar();
    public void Uyu()
    {
        Console.WriteLine("Hayvan uyuyor");
    }

    public virtual void YemekYe()
    {
        Console.WriteLine("Hayvan et yiyor.");
    }
}