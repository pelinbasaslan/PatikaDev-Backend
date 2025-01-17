
List<Car> cars = new List<Car>();
Console.WriteLine("Araba üretmek ister misiniz?(e/h):");
yes: string userInput = Console.ReadLine().ToLower();
if (userInput == "e")
{
    Car newCar = new Car();
    Console.Write("Arabanın seri numarası:");
    newCar.SerialNumber = Console.ReadLine();
    Console.Write("Arabanın markası:");
    newCar.Brand = Console.ReadLine();
    Console.Write("Arabanın modeli:");
    newCar.Model = Console.ReadLine();
    Console.Write("Arabanın rengi:");
    newCar.Color = Console.ReadLine();
door: Console.Write("Arabanın kapı sayısı:");
    bool doorNumberIsANumber = int.TryParse(Console.ReadLine(), out int doorNumber);
    if (doorNumberIsANumber)
    {
        newCar.DoorNumber = doorNumber;
    }
    else
    {
        Console.WriteLine("Yanlış girdi.");
        goto door;
    }
    Console.WriteLine("Araba oluşturuldu.");
    cars.Add(newCar);

    Console.Write("Başka bir araba üretmek ister misiniz? (e/h):");
    goto yes;

}
else if (userInput == "h")
{
    Console.WriteLine("Araba üretmek istemediğiniz için program sonlandırılıyor.");
    foreach (var item in cars)
    {
        Console.WriteLine(item.Brand + " markalı aracın " + "seri numarası: " + item.SerialNumber);
    }
}
else
{
    Console.Write("Yanlış girdi. Tekrardan giriniz: (e/h):");
    goto yes;
}

