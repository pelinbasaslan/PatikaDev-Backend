public class Sarkıcı : BaseKatilimci
{
    public string SoyledigiSarki { get; set; }

    void SarkiSoyle()
    {
        Console.WriteLine(Ad + " " + SoyAd + "Şarkı söylüyor");
    }


}