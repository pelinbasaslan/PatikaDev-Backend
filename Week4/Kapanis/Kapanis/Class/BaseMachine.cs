public abstract class BaseMachine
{
    /* 
    public DateTime ProductionDate
    {
        get
        { return DateTime.Now; } 
        set { }
    } 
    DateTime i now olarak böyle tanımlamıştım ancak Constructor olarak tanımlamak mantıklı çünkü aşağıdaki gibi olduğunda her defasında tarih aslında güncelleniyor. Constructor olarak yapsaydım nesne oluştuğu anda bir tarih oluşmuş oluyor:
    public class Program
    {
        public static void Main()
        {
            // Computer nesnesini oluşturuyoruz
            Computer computer1 = new Computer();
        
            // Nesneyi oluşturduğumuz anda ProductionDate'i bir kez alalım
            Console.WriteLine("İlk erişimdeki tarih: " + computer1.ProductionDate);
        
            // Bir süre bekleyip tekrar aynı özelliğe erişelim
            System.Threading.Thread.Sleep(2000);  // 2 saniye bekleyelim

            // Tekrar eriştiğimizde tarih değişmiş olmalı
            Console.WriteLine("İkinci erişimdeki tarih: " + computer1.ProductionDate);
        }
    } Konsola yazılmış hali: 
        İlk erişimdeki tarih: 14.01.2025 12:34:56
        İkinci erişimdeki tarih: 14.01.2025 12:34:58
    */

    public BaseMachine()
    {
        ProductionDate = DateTime.Now; //Nesne oluştuğundaki tarih. Nesnenin üretim tarihi böylelikle sabit oluyor.
    }
    public DateTime ProductionDate { get; set; }
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