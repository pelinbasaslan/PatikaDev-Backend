public class Computer : BaseMachine //BaseMachineden inherit.
{
    private int _USBPortCount; //Field tanımladım. Kapsülleme yapmak için
    public int USBPortCount
    {
        get
        {
            return _USBPortCount;
        }
        set
        {
            if (value == 2 || value == 4)
            {
                _USBPortCount = value;
            }
            else
            {
                Console.WriteLine("USB giriş sayısı 2 veya 4 olmadığı için -1 olarak geri dönüş olacak.");
                _USBPortCount = -1;
            }
        }
    }

    private bool _bluetooth;
    public bool Bluetooth
    {
        get 
        { 
            return _bluetooth; 
        }

        set
        {
            _bluetooth = value;
            if (value == true)
                Console.WriteLine("Bluetooth var.");
            else
                Console.WriteLine("Bluetooth yok.");
            
        }
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"USB giriş sayısı: {USBPortCount}, Bluetooth girişi: {Bluetooth}, Üretim tarihi: {ProductionDate}, Seri numarası: {SerialNumber}, İsmi: {Name}, Açıklaması: {Info}, İşletim Sistemi: {OperationSystem}.");
    }


    public override void PrintTheNameOfProduct() //abstractı override ettik.
    {
        Console.WriteLine("Ürün bilgisayar. ");
    }


}