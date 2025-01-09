public abstract class BaseMachine
{
    public DateTime ProductionDate
    {
        get
        { return DateTime.Now; }
        set { }
    }
    public string SerialNumber { get; set; }
    public string Name { get; set; }
    public string Info { get; set; }
    public string OperationSystem { get; set; }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Üretim tarihi: {ProductionDate}, Seri numarası: {SerialNumber}, İsmi: {Name}, Açıklaması: {Info}, İşletim Sistemi: {OperationSystem}.");
    }

    public abstract void PrintTheNameOfProduct(); //abstract yaptım ki telefon çağırınca telefon yazıcak bilgisayar yazınca bilgisayar. Burada metotu hiç tanımlamıyorsun abstract olunca. 

}