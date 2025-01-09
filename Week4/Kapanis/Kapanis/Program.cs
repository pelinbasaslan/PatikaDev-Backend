bool continueProgram = true;

while (continueProgram)
{
    Console.WriteLine("Telefon üretmek için 1'e bilgisayar üretmek için 2'ye basmanız gerekiyor.");
    bool isItANumber = int.TryParse(Console.ReadLine(), out int number);
    while (true)
    {
        if (isItANumber)
        {
            if (number == 1 || number == 2)
                break;
            else
                Console.WriteLine("Yanlış girdi. Tekrardan giriniz: ");
        }
        else
            Console.WriteLine("Lütfen sayı giriniz:");
        isItANumber = int.TryParse(Console.ReadLine(), out number);
    }

    if (number == 1)
    {
        Telephone telephone = new Telephone(); //Metamorfis
        telephone.PrintTheNameOfProduct();
        Console.Write("Telefon Adı:");
        telephone.Name = Console.ReadLine();
        Console.Write("Telefon Bilgisi:");
        telephone.Info = Console.ReadLine();
        Console.Write("Telefon İşletim Sistemi:");
        telephone.OperationSystem = Console.ReadLine();
        Console.Write("Telefon Seri Numarası:");
        telephone.SerialNumber = Console.ReadLine();
        Console.Write("Telefon TR Lisanslı mı?E/H:");
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "e")
            telephone.TRLisans = true;
        else
            telephone.TRLisans = false;

        telephone.PrintInfo();
        Console.WriteLine("Ürün başarıyla oluşturuldu. Başa dönmek ister misin?(E/H)");
        string wantToContinueProgram = Console.ReadLine().ToLower();
        if (wantToContinueProgram != "e")
        {
            continueProgram = false;
            Console.WriteLine("İyi günler. Program Sonlandırıldı.");
        }
    }
    else
    {
        Computer computer = new Computer();
        computer.PrintTheNameOfProduct();
        Console.Write("Bilgisayar Adı:");
        computer.Name = Console.ReadLine();
        Console.Write("Bilgisayar Bilgisi:");
        computer.Info = Console.ReadLine();
        Console.Write("Bilgisayar İşletim Sistemi:");
        computer.OperationSystem = Console.ReadLine();
        Console.Write("Bilgisayar Seri Numarası:");
        computer.SerialNumber = Console.ReadLine();
        Console.WriteLine("Bluetooth desteği var mı?E/H");
        string userInput2 = Console.ReadLine().ToLower();
        if (userInput2 == "e")
            computer.Bluetooth = true;
        else
            computer.Bluetooth = false;
        Console.WriteLine("USB giriş sayısı:");
        computer.USBPortCount = Convert.ToInt32(Console.ReadLine());
        computer.PrintInfo();

        Console.WriteLine("Ürün başarıyla oluşturuldu. Başa dönmek ister misin?(E/H)");
        string wantToContinueProgram = Console.ReadLine().ToLower();
        if (wantToContinueProgram != "e")
        {
            continueProgram = false;
            Console.WriteLine("İyi günler. Program Sonlandırıldı.");
        }
    }

}