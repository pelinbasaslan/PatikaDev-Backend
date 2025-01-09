public class BaseGeometrikSekil
{
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }

    public virtual int AlanHesapla()
    {
        int alan= Genislik * Yukseklik;
        return alan;
    }
}

public class Kare : BaseGeometrikSekil
{
    public Kare(int kenar)
    {
        Genislik = kenar;
        Yukseklik = kenar;
    }
}

public class Dikdortgen : BaseGeometrikSekil{}

public class Ucgen : BaseGeometrikSekil
{
    public override int AlanHesapla()
    {
        int alan = Genislik * Yukseklik / 2;
        return alan;
    }
}

