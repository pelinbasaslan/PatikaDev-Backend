using System.Runtime.Intrinsics.X86;
using encapsulation_pratik4;

Araba araba = new Araba();
araba.Marka = "Marka1";
araba.Model = "Model1";
araba.KapiSayisi = 3;
araba.Renk = "kırmızı";
araba.ArabayiTanit();
araba.KapiSayisiniSoyle();

Araba araba2 = new Araba();
araba2.Marka = "Marka2";
araba2.Model = "Model2";
araba2.KapiSayisi = 2;
araba2.Renk = "siyah";
araba2.ArabayiTanit();
araba2.KapiSayisiniSoyle();

Araba araba3 = new Araba("Model3", "Marka3", "bordo", 3);
araba3.ArabayiTanit();
araba3.KapiSayisiniSoyle();

