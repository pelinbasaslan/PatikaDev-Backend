BaseGeometrikSekil kare = new Kare(2); //Polimorfis örneği. 
Console.WriteLine("Karenin alanı: " + kare.AlanHesapla());

Kare kare2 = new Kare(5);
Console.WriteLine("Kare 2nin alanı: " + kare2.AlanHesapla()); //Burada inheritancedan metodu ya da değişkenleri çağırıyor.

BaseGeometrikSekil dikdortgen = new Dikdortgen();//Polimorfis örneği. 
dikdortgen.Yukseklik = 2;
dikdortgen.Genislik = 6;
Console.WriteLine("Dikdörtgenin alanı: " + dikdortgen.AlanHesapla());

BaseGeometrikSekil ucgen = new Ucgen();//Polimorfis örneği. 
ucgen.Yukseklik = 3;
ucgen.Genislik = 6;
Console.WriteLine("Üçgenin alanı: " + ucgen.AlanHesapla());