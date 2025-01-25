//Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.
using System.Security.Cryptography.X509Certificates;

List<int> randomSayilar = new List<int>();

for (int i = 0; i < 10; i++)
{
    Random random = new Random();
    randomSayilar.Add(random.Next(-100,100));
}

Console.WriteLine("Sayılar:");
foreach (var item in randomSayilar)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");


//Çift olan sayılar
var evenNumbers = randomSayilar.Where(x => x % 2 == 0);
Console.WriteLine("Çift sayılar:");
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");

//Tek olan sayılar
var notEvenNumbers = randomSayilar.Where(x => x % 2 != 0);
Console.WriteLine("Tek sayılar:");
foreach (var item in notEvenNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");

//Negatif sayılar
var negatifNumbers = randomSayilar.Where(x => x < 0);
Console.WriteLine("Negatif Sayılar:");
foreach (var item in negatifNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");

//Pozitif Sayılar
var pozitifNumbers = randomSayilar.Where(x => x > 0);
Console.WriteLine("Pozitif sayılar:");
foreach (var item in pozitifNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");

//15'ten büyük ve 22'den küçük sayılar
var belliAraliktakiSayi = randomSayilar.Where(x => x > 15 && x < 22);
Console.WriteLine("15'ten büyük ve 22'den küçük sayılar");
if (belliAraliktakiSayi.Count()==0)
{
    Console.WriteLine("15'ten büyük ve 22'den küçük bir sayı yok.");
}
foreach (var item in belliAraliktakiSayi)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");

//Listedeki her bir sayının karesi 
List<int> sayilarinKaresi = randomSayilar.Select(x => x * x).ToList();
for (int i = 0; i < sayilarinKaresi.Count(); i++)
{
    Console.WriteLine(randomSayilar[i]+"sayısının karesi: "+ sayilarinKaresi[i]);
}