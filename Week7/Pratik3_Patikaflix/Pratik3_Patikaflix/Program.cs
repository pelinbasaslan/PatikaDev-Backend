using Pratik3_Patikaflix;

List<Series> seriesList = new List<Series>(){
    new Series { Name = "Avrupa Yakası", ProductionDate = 2004, Genre = "Komedi", ReleaseDate = 2004, Director = "Yüksel Aksu", Platform = "Kanal D" },
    new Series { Name = "Yalan Dünya", ProductionDate = 2012, Genre = "Komedi", ReleaseDate = 2012, Director = "Gülseren Buda Başkaya", Platform = "Fox TV" },
    new Series { Name = "Jet Sosyete", ProductionDate = 2018, Genre = "Komedi", ReleaseDate = 2018, Director = "Gülseren Buda Başkaya", Platform = "TV8" },
    new Series { Name = "Dadı", ProductionDate = 2006, Genre = "Komedi", ReleaseDate = 2006, Director = "Yusuf Pirhasan", Platform = "Kanal D" },
    new Series { Name = "Belalı Baldız", ProductionDate = 2007, Genre = "Komedi", ReleaseDate = 2007, Director = "Yüksel Aksu", Platform = "Kanal D" },
    new Series { Name = "Arka Sokaklar", ProductionDate = 2004, Genre = "Polisiye,Dram", ReleaseDate = 2004, Director = "Orhan Oğuz", Platform = "Kanal D" },
    new Series { Name = "Aşkı Memnu", ProductionDate = 2008, Genre = "Dram,Romantik", ReleaseDate = 2008, Director = "Hilal Saral", Platform = "Kanal D" },
    new Series { Name = "Muhteşem Yüzyıl", ProductionDate = 2011, Genre = "Tarihi,Dram", ReleaseDate = 2011, Director = "Mercan Çilingiroğlu", Platform = "Star TV" },
    new Series { Name = "Yaprak Dökümü", ProductionDate = 2006, Genre = "Dram", ReleaseDate = 2006, Director = "Serdar Akar", Platform = "Kanal D" },
    };

//1)İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)

List<Comedy> comedies = seriesList
                        .Where(x => x.Genre == "Komedi")
                        .Select(x=> new Comedy{NameComedy=x.Name, DirectorComedy=x.Director, GenreComedy=x.Genre})    
                        .ToList();

//2)Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.
var orderedComedyList= comedies.OrderBy(x => x.NameComedy)
                                .ThenBy(x => x.DirectorComedy)
                                .ToList();

foreach (var item in orderedComedyList)
{
    item.DisplayInfo();
}