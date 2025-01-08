using live1;

Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Isim = "Botan";
ogrenci1.SoyIsim = "Elveren";
ogrenci1.Yas = 34;
ogrenci1.Hobi = "Trompet";
ogrenci1.GozlukluMu = false;

Ogrenci ogrenci2 = new Ogrenci()
{
    Isim = "Ahmet",
    SoyIsim = "Ucar",
    Yas = 26,
    Hobi = "Piyano",
    GozlukluMu = true,
};

//Propertyye değer atarken set metodunu tetiklersin.

//propertyde değer okunurken get metodu tetiklersin.

Console.WriteLine("----------------");
Ogrenci yeniOgrenci = new Ogrenci();
Console.WriteLine(yeniOgrenci.Isim);
Console.WriteLine(yeniOgrenci.SoyIsim);
Console.WriteLine(yeniOgrenci.Yas);
Console.WriteLine(yeniOgrenci.Hobi);
Console.WriteLine(yeniOgrenci.GozlukluMu);






