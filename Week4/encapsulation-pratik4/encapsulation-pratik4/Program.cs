using System.Runtime.Intrinsics.X86;
using encapsulation_pratik4;

Araba araba = new Araba();
araba.Marka = "Mercedes";
araba.Model = "C200";
araba.KapiSayisi = 4;
araba.Renk = "kırmızı";

Araba araba2 = new Araba();
araba2.Marka = "BMW";
araba.Model = "5";
araba.KapiSayisi = 4;
araba.Renk = "Siyah";

araba.ArabayiTanit();
araba2.ArabayiTanit();

