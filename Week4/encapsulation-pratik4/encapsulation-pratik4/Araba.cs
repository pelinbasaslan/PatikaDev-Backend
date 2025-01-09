namespace encapsulation_pratik4
{
    public class Araba
    {
        private int kapiSayisi;

        public int KapiSayisi
        {
            get
            {
                return kapiSayisi;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    kapiSayisi = value;

                }
                else
                {
                    kapiSayisi = -1;
                    Console.WriteLine("Girilen değerde bir kapı sayısı yoktur. Yanlış girdi.");
                }

            }
        }

        public string Model { get; set; }
        public string Marka { get; set; }
        public string Renk { get; set; }

        public Araba()
        {
            KapiSayisi = 4;
        }

        public Araba(string model, string marka, string renk, int kapiSayisi)
        {
            Model = model;
            Marka = marka;
            Renk = renk;
            KapiSayisi = kapiSayisi;
        }

        public void ArabayiTanit()
        {
            Console.WriteLine($"{Model} model arabanın markası {Marka}, rengi {Renk}");
        }

        public void KapiSayisiniSoyle()
        {
            if (kapiSayisi != -1)
                Console.WriteLine($"Kapı Sayısı: {kapiSayisi}");
        }

    }
}