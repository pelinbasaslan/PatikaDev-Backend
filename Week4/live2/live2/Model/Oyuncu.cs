using System.ComponentModel;

public class Oyuncu : BaseKatilimci
{
    public string OynamaktaOlduguProje { get; set; }

    void RolYap()
    {
        Console.WriteLine(Ad + " " + SoyAd + " rol yapıyor.");
    }

}