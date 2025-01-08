using System;
namespace live1
{
    internal class Ogrenci
    {
        public Ogrenci() //ctor kısaltma
        {

        }
        public Ogrenci(string isim, string soyIsim)
        {
            Isim = isim;
            SoyIsim = soyIsim;

        }
        //method overloading negatif bir şey değil birden fazla görev verilmesi. 
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public int Yas { get; set; }
        public string Hobi { get; set; }
        public bool GozlukluMu { get; set; }

    }
}