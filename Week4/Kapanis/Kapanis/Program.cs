List<Computer> computers = new List<Computer>();
List<Telephone> telephones = new List<Telephone>();

while (true)
{
baslangıc: Console.WriteLine("Telefon üretmek için 1'e bilgisayar üretmek için 2'ye basmanız gerekiyor.");
    int userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput == 1)
    {
        Computer computer = new Computer();
        Console.Write("Bilgisayar Adı:");
        computer.Name = Console.ReadLine();
    soru2: Console.WriteLine("Bluetooth desteği var mı?E/H");
        char answerBluetooth = Convert.ToChar(Console.ReadLine());
        if (answerBluetooth == 'e')
        {
            computer.Bluetooth = true;
        }
        else if (answerBluetooth == 'h')
        {
            computer.Bluetooth = false;
        }
        else
        {
            Console.WriteLine("Yanlış girdi. Tekrar deneyiniz.");
            goto soru2;
        }
        Console.WriteLine("USB Giriş Sayısı:");
        computer.UsbPortCount = int.Parse(Console.ReadLine());
        computers.Add(computer);
    }
    else if (userInput == 2)
    {
        Telephone telephone = new Telephone(); //Metamorfis
        Console.Write("Telefon Adı:");
        telephone.Name = Console.ReadLine();
    soru: Console.Write("Telefon TR Lisanslı mı?(e/h):");
        char answer = Convert.ToChar(Console.ReadLine());
        if (answer == 'e')
            telephone.TRLisans = true;
        else if (answer == 'h')
            telephone.TRLisans = false;
        else
        {
            Console.WriteLine("Yanlış girdi. Lütfen yeniden giriniz.");
            goto soru;
        }
        telephones.Add(telephone);
    }
    else
    {
        Console.WriteLine("Yanlış bir girdi.");
        goto baslangıc;
    }

    Console.WriteLine("Yeniden ekleme işlemi yapmak istiyor musunu? (e/h)");
    char continueProgram = Convert.ToChar(Console.ReadLine());
    if (continueProgram == 'h')
        break;

}

Console.WriteLine("------Bilgisayarlar-------");
foreach (var computer in computers)
{
    computer.PrintInfo();
    Console.WriteLine("----");
}

Console.WriteLine("-----Telefonlar-----");
foreach (var telephone in telephones)
{
    telephone.PrintInfo();
}














/*
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
        computer.UsbPortCount = Convert.ToInt32(Console.ReadLine());
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
*/