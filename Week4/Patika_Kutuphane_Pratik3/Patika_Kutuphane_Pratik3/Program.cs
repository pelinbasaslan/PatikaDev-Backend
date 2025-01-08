Book kitap1 = new Book();
kitap1.Name = "Yeni Kitap Adı";
kitap1.AuthorsName = "Yazar Adı";
kitap1.AuthorsSurName = "Yazar Soyadı";
kitap1.TotalPage = 0;
kitap1.Publisher = "Yayınevi";
kitap1.KitabiTanit();

Book kitap2 = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
kitap2.KitabiTanit();

//new ile yeni nesne oluşturuluyor. Book classımı newleyerek bir kitap1 nesnesi ve kitap2 nesnesi oluşturdum.

Book AyseKulinKitaplari = new Book("Ayşe", "Kulin");
AyseKulinKitaplari.KitabiTanit();

Book KitapIsmiGecenKitap = new Book("Kitap");
KitapIsmiGecenKitap.KitabiTanit();




