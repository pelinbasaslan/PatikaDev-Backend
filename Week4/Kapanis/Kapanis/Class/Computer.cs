public class Computer : BaseMachine //BaseMachineden inherit.
{
    private int _usbPortCount; //Field tanımladım. Kapsülleme yapmak için
    public int UsbPortCount
    {
        get
        {
            return _usbPortCount;
        }
        set
        {
            if (value == 2 || value == 4)
            {
                _usbPortCount = value;
            }
            else
            {
                //Console.WriteLine("USB giriş sayısı 2 veya 4 olmadığı için -1 olarak geri dönüş olacak.");
                _usbPortCount = -1;
            }
        }
    }

    /*
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
    */

    public bool Bluetooth { get; set; }

    public override void PrintInfo()
    {
        //Console.WriteLine(Bluetooth? "Bluetooth var":"Bluetooth yok."); Bunu $"" ifadesi içinde kullanıyorsak paranteze almak gerekiyor. 
        Console.WriteLine($"USB giriş sayısı: {UsbPortCount}, Bluetooth var mı?: {(Bluetooth ? "Bluetooh var" : "Bluetooth yok.")}, Üretim tarihi: {ProductionDate}, Seri numarası: {SerialNumber}, İsmi: {Name}, Açıklaması: {Info}, İşletim Sistemi: {OperationSystem}.");
    }


    public override void PrintTheNameOfProduct() //abstractı override ettik.
    {
        Console.WriteLine("Ürün bilgisayar. ");
    }


}