using LiveTue;

Kedi kedi = new Kedi()
{
    Ad = "Kediş",
    Tur = "Van"
};
Kopek kopek = new Kopek()
{
    Ad = "Aşil",
    Tur = "Cocker"
};

kedi.SesCıkar();
kedi.Uyu();
kedi.YemekYe();

kopek.SesCıkar();
kopek.Uyu();
kopek.YemekYe();

var sahip = new Sahip();
sahip.HayvanlariListele();
sahip.HayvanEkle(kedi);
sahip.HayvanEkle(kopek);
sahip.HayvanlariListele();