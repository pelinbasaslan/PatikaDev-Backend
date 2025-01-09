public class Telephone : BaseMachine //BaseMachineden inherit.
{
    private bool _TRLisansli;

    public bool TRLisans
    {
        get
        {
            return _TRLisansli;
        }
        set
        {
            _TRLisansli = value;

            if (value == true)
            {
                Console.WriteLine("TR Lisanslı.");
            }
            else
            {
                Console.WriteLine("TR Lisansı yok.");
            }

        }
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Türkiye Lisanslı: {TRLisans}, Üretim tarihi: {ProductionDate}, Seri numarası: {SerialNumber}, İsmi: {Name}, Açıklaması: {Info}, İşletim Sistemi: {OperationSystem}.");
    }

    public override void PrintTheNameOfProduct() //abstractı override ettik.
    {
        Console.WriteLine("Ürün telefon. ");
    }

}