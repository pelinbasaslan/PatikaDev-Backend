//Eğer ki 10 eleman kesin olcak diyorsan dizi ile ama eğer ki belli değilse ve ekleme çıkarma yapacaksan elemanına list ile yapmak mantıklı.
/*
List<int> sayilar = new List<int>();
sayilar.Add(5);
sayilar.Add(3);//
sayilar.Add(3);
sayilar.Add(3);
sayilar.Add(3);
sayilar.Add(7);
sayilar.Add(2);
sayilar.Add(3);

Console.WriteLine("Liste eleman sayisi ---> " + sayilar.Count);
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------");
for (int i = 0; i < sayilar.Count; i++)
{
    Console.WriteLine(sayilar[i]);
}

//Değer ile silme
sayilar.Remove(3);
Console.WriteLine("Son eleman sayısı 3 değeri çıkarılınca ---> " + sayilar.Count);
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

//Index ile silme
sayilar.RemoveAt(1);
foreach (var item in sayilar)
{
    System.Console.WriteLine(item);
}
*/

List<string> sarkicilar = new List<string>();
sarkicilar.Add("Ajda Pekkan");
sarkicilar.Add("Buika");
sarkicilar.Add("Hande Yener");
for (int i = 0; i < sarkicilar.Count; i++)
{
    Console.WriteLine(sarkicilar[i]);
}

