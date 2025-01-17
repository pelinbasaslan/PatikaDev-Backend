//1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
int[] numbers = new int[10];
Console.WriteLine("------------------");

//2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i;
}
foreach (var item in numbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");

//3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
int[] numbersNew = new int[11];
numbers.CopyTo(numbersNew, 0); //0: Bu parametre, kopyalamanın numbersNew dizisinin 0. indeksinden başlamasını sağlıyor.
Console.Write("Bir sayı giriniz:");
int userNumber = Convert.ToInt32(Console.ReadLine());
numbersNew[10] = userNumber;

foreach (var item in numbersNew)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");

/*
public void CopyTo(Array array, int arrayIndex);
public void CopyTo(int index, Array array, int arrayIndex, int length);

1.index: Kopyalamaya başlamak istediğiniz dizinin indeksini belirtir.
2.array: Elemanları kopyalamak istediğiniz hedef dizi.
3.arrayIndex: Hedef dizide kopyalama işlemine başlayacağınız indeks.
4.length: Kopyalanacak eleman sayısı.

int[] numbersNew= new int[11];
numbers.CoppyTo(0,numbersNew,0,10);
numbersNew[numbersNew.Length-1] = userNumber;
*/

//4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
Array.Sort(numbersNew);
Array.Reverse(numbersNew);
foreach (var item in numbersNew)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");
