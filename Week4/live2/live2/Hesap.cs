public class Hesap
{
    private decimal _bakiye; //Gete müdahale ya da sete müdahale kapsüllemedir. müdahale yoksa kapsülleme yok. 

    public decimal Bakiye //Erişim noktası
    {
        get
        { return _bakiye; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Negatif bir bakiye atanamaz.");
            }
            else
            {
                _bakiye = value;
            }
        }
    }
}