using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Pratik2_Patikafy;

//11 sanatçımız için bir veri tablosu verilmiştir. Tablodaki her bir satır bir nesneye karşılık gelecek şekilde bu nesnelerden oluşan bir liste tanımlayınız. Ardından bu liste üzerinden aşığıdaki sorguları gerçekleştiriniz.
List<Artist> artistList = new List<Artist>
{
    new Artist("Ajda Pekkan", "Pop", 1968, "Yaklaşık 20 milyon"),
    new Artist("Sezen Aksu", "Türk Halk Müziği/Pop", 1971, "Yaklaşık 10 milyon"),
    new Artist("Funda Arar", "Pop", 1999, "Yaklaşık 3 milyon"),
    new Artist("Sertab Erener", "Pop", 1994, "Yaklaşık 5 milyon"),
    new Artist("Sıla", "Pop", 2009, "Yaklaşık 3 milyon"),
    new Artist("Serdar Ortaç", "Pop", 1994, "Yaklaşık 10 milyon"),
    new Artist("Tarkan", "Pop", 1992, "Yaklaşık 40 milyon"),
    new Artist("Hande Yener", "Pop", 1999, "Yaklaşık 7 milyon"),
    new Artist("Hadise", "Pop", 2005, "Yaklaşık 5 milyon"),
    new Artist("Gülben Ergen", "Pop/Türk Halk Müziği", 1997, "Yaklaşık 10 milyon"),
    new Artist("Neşet Ertaş", "Türk Halk Müziği/Türk Sanat Müziği", 1960, "Yaklaşık 2 milyon"),
};
Console.WriteLine("----------------");

//Adı 'S' ile başlayan şarkıcılar
var artistWhichNameStartWithS = artistList.Where(x => x.Name.StartsWith('S')).ToList();
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
foreach (var item in artistWhichNameStartWithS)
{
    item.DisplayNameInfo();
}
Console.WriteLine("----------------");

//Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
var albumSalesMoreThan10 = artistList.Where(x => Convert.ToInt32(x.AlbumSales.Split(' ')[1]) > 10);
Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar");
foreach (var item in albumSalesMoreThan10)
{
    item.DisplayNameInfo();
}
Console.WriteLine("----------------");

//2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.

var before2000AndPopGenre = artistList
.Where(x => x.DateOfDebut < 2000 && x.Genre.Contains("Pop"))
.GroupBy(x => x.DateOfDebut)
.Select(group=> new 
{DebutYear=group.Key,
Artists= group.Select
(x=> new Artist{Name=x.Name, AlbumSales=x.AlbumSales, DateOfDebut=x.DateOfDebut, Genre=x.Genre}).OrderBy(x=> x.Name)})
.OrderBy(x=> x.DebutYear).ToList();

foreach (var group in before2000AndPopGenre)
{
    Console.WriteLine($"Albüm çıkarma tarihi: {group.DebutYear}");
    foreach (var artist in group.Artists)
    {
        Console.WriteLine($"  - {artist.Name}");
    }
}
Console.WriteLine("----------------");

//En çok albüm satan şarkıcı
var theBestSalesAlbum = artistList.OrderByDescending(x => Convert.ToInt32(x.AlbumSales.Split(' ')[1])).First();
Console.WriteLine("En çok albüm satan sanatçı: "+ theBestSalesAlbum.Name);
Console.WriteLine("----------------");

//En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
var theNewestDebut = artistList.OrderByDescending(x => x.DateOfDebut).First();
var theOldestDebut = artistList.OrderBy(x => x.DateOfDebut).First();
Console.WriteLine($"En yeni çıkış yapan şarkıcı: {theNewestDebut.Name}, en eski çıkış yapan şarkıcı: {theOldestDebut.Name} ");




