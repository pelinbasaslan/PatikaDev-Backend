
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using ChatGPT_Pratik;

Console.WriteLine("------SORU 1------");
Question1();

Console.WriteLine("------SORU 2------");
Question2();

Console.WriteLine("------SORU 3------");
Question3();

Console.WriteLine("------SORU 4------");
Question4();

Console.WriteLine("------SORU 5------");

/*
Soru 5: Öğrenciler ve Notlar
Bir Student sınıfı oluştur. Her öğrencinin adı ve notları olsun.

Ortalama notu en yüksek olan öğrenciyi bul.
Ortalama notu 50'nin altında olan öğrencileri listele.
Tüm öğrencilerin ortalama notunu hesapla.

*/

Console.WriteLine("------SORU 6------");
/*
Soru 6: Filmler ve Türler
Bir Movie sınıfı oluştur. Her filmin adı, türü ve IMDB puanı olsun.

IMDB puanı 8'den yüksek olan filmleri listele.
Filmleri türe göre grupla.
Her türe ait filmlerden en yüksek puanlı olanı bul.

*/

Console.WriteLine("------SORU 7------");
/*
Soru 7: Araçlar ve Fiyatlandırma
Bir Car sınıfı oluştur. Her aracın markası, modeli ve fiyatı olsun.

Fiyatı 200.000'den düşük olan araçları listele.
Araçları markaya göre grupla.
Her markanın en ucuz aracını bul.
*/



/*
Soru 1: Çalışanlar ve Maaş Filtreleme.
Bir Employee sınıfı oluştur. Her çalışanın adı ve maaşı olsun.

Çalışanları maaşı 5000'den fazla olanlar ve olmayanlar olarak iki listeye ayır.
Toplam maaşı hesapla.
En yüksek maaşlı çalışanı bul.
*/
static void Question1()
{
    List<Employee> employees = new List<Employee>{

    new Employee("Ahmet",5000),
    new Employee("Mehmet", 3000),
    new Employee("Mehmet Ali", 15000),
    new Employee("Aslı", 8000),
    new Employee("Ayşe", 9000),
    new Employee("Fatma", 1000),
    new Employee("Gül", 6000),
    new Employee("Murat", 9000),
    new Employee("Veysel", 13000),
    new Employee("Veli", 32000),
    new Employee("Zeynep", 3600),
    new Employee("Hasan", 32000),
    };
    var employeesGetMoreThan5000 = employees.Where(x => x.Salary > 5000).ToList();
    foreach (var item in employeesGetMoreThan5000)
    {
        item.DisplayInfo();
    }
    Console.WriteLine("--------------------");

    var employeesGetLessThan5000 = employees.Where(x => x.Salary < 5000).ToList();
    foreach (var item in employeesGetLessThan5000)
    {
        item.DisplayInfo();
    }
    Console.WriteLine("--------------------");

    decimal totalSalary = 0;
    for (int i = 0; i < employees.Count; i++)
    {
        totalSalary += employees[i].Salary;
    }
    ;

    Console.WriteLine("Maaş toplamı : " + totalSalary);
    Console.WriteLine("--------------------");

    //alternatif
    var totalSalaryCalculate = employees.Sum(x => x.Salary);
    Console.WriteLine("Sum fonk ile hesaplama: " + totalSalaryCalculate);
    Console.WriteLine("--------------------");

    var employeesWhoseGetMore = employees.OrderByDescending(x => x.Salary).First();
    Console.WriteLine("En fazla maaşı alan çalışan: " + employeesWhoseGetMore.Name + " aldığı maaş: " + employeesWhoseGetMore.Salary); //burada employeesWhoseGetMore bir tek bir Employee nesnesi olduğu için Name özelliğine doğrudan erişebilirsin. Bu, First() metodunun doğru kullanımıyla elde edilen tek bir öğedir ve bu öğe, bir Employee nesnesi olduğu için onun özelliklerine (örneğin, Name ve Salary) doğrudan ulaşılabilir.

    var maxSalary = employees.Max(x => x.Salary);
    var employeesMaxSalary = employees.Where(x => x.Salary == maxSalary).ToList();

    foreach (var item in employeesMaxSalary)
    {
        item.DisplayInfo();
    }
}
;


/*
Soru 2: Ürünler ve Stok Yönetimi
Bir Product sınıfı oluştur. Her ürünün adı, fiyatı ve stok miktarı olsun.

Stokta 10'dan az olan ürünleri listele.
Fiyatı en yüksek olan ilk 3 ürünü bul.
Tüm ürünlerin toplam değerini (stok miktarı * fiyat) hesapla.
*/
static void Question2()
{
    List<Product> products = new List<Product>()
    {
        new Product{Name="Iphone 16", Price=1000, Stock=2},
        new Product{Name="MacBook", Price=500, Stock=30},
        new Product{Name="Samsung", Price=800, Stock=5},
        new Product{Name="Dyson v15", Price=400, Stock=50},
        new Product{Name="Grundig Kurutma", Price=300, Stock=3},
        new Product{Name="Xiami s10t", Price=200, Stock=70},
        new Product{Name="Mac Air", Price=1000, Stock=10},
    };

    Console.WriteLine("Stokta 10'dan az olan ürünleri listele.");
    var stockLessThan10 = products.Where(x => x.Stock < 10);
    foreach (var item in stockLessThan10)
    {
        item.DisplayInfoProducts();
    }
    Console.WriteLine("------------------");

    Console.WriteLine("Fiyatı en yüksek olan ilk 3 ürünü bul.");
    var mostExpensiveThreeProduct = products
                                    .OrderByDescending(x => x.Price)
                                    .Take(3)
                                    .ToList();
    foreach (var item in mostExpensiveThreeProduct)
    {
        item.DisplayInfoProducts();
    }
    Console.WriteLine("------------------");

    var sumProductTotal = products.Sum(x => x.Price * x.Stock);
    Console.WriteLine("Tüm ürünlerin toplam değeri (stok miktarı * fiyat):" + sumProductTotal);
    Console.WriteLine("------------------");



}


/*
Soru 3: Kitaplar ve Kategoriler
Bir Book sınıfı oluştur. Her kitabın adı, yazarı ve kategorisi olsun.

Belirli bir kategoriye ait kitapları listele.
Aynı yazara ait kitapları grupla.
Her kategoride kaç kitap olduğunu hesapla.
*/
static void Question3()
{
    List<Book> bookList = new List<Book>()
    {
        new Book{Title="Kitap Adı", Author="Letti Guise", Category="Kategori"},
        new Book{Title="The Corsican Brothers",Author="Vonny Clucas",Category="Adventure"},
        new Book{Title="Care Bears Movie, The",Author="Vonny Clucas",Category="Animation|Children|Fantasy"},
        new Book{Title="Moulin Rouge",Author="Letti Guise",Category="Drama"},
        new Book{Title="Dragon Age: Blood mage no seisen (a.k.a. Dragon Age: Dawn of the Seeker)",Author="Sheilah Toop",Category="Animation|Fantasy"},
        new Book{Title="Dr. Who and the Daleks",Author="Herschel Kubala",Category="Adventure|Children|Sci-Fi"},
        new Book{Title="Winter Nomads",Author="Harwilll Manske",Category="Documentary"},
        new Book{Title="Wyoming Renegades",Author="Harwilll Manske",Category="Romance|Western"},
        new Book{Title="Bey Yaar",Author="Ingelbert Jacobs",Category="Children|Comedy|Drama"},
        new Book{Title="Prize, The",Author="Harwilll Manske",Category="Drama|Mystery|Thriller"},

    };

    //var dramaList = bookList.Select(x => x.Category).Contains("Drama");
    //foreach (var item in dramaList) dramaList bool oluyor

    var dramaList = bookList.Where(x => x.Category.Contains("Drama"));
    Console.WriteLine("Drama kitapları");
    foreach (var item in dramaList)
    {
        item.DisplayBookInfo();
    }
    Console.WriteLine("------------------");

    Console.WriteLine("Kitaplar yazarlarla gruplandırıldı.");
    var groupByAuthorList = bookList.GroupBy(x => x.Author);
    foreach (var group in groupByAuthorList)
    {
        Console.WriteLine("Yazar: " + group.Key);
        foreach (var item in group)
        {
            Console.WriteLine("Kitap adı: " + item.Title);
        }
    }
    Console.WriteLine("------------------");

    Console.WriteLine("Kitaplar kategori ile gruplandırıldı.");
    var groupByCategory = bookList
                        .SelectMany(x => x.Category.Split('|'), (book, category) => new { book.Title, Category = category })
                        .GroupBy(x => x.Category);


    foreach (var group in groupByCategory)
    {
        Console.WriteLine("Kategori: " + group.Key);
        Console.WriteLine("Her kategoride olan kitap sayısı: " + group.Count());
    }
    Console.WriteLine("------------------");
}

/*
Soru 4: Müşteriler ve Siparişler
Bir Customer ve bir Order sınıfı oluştur.

Her müşteri birden fazla siparişe sahip olabilir.
Belirli bir müşterinin siparişlerini listele.
Tüm siparişler arasında toplam sipariş tutarını bul.
En çok sipariş veren müşteriyi bul.
*/
static void Question4()
{
    List<Customer> customers = new List<Customer>(){
        new Customer{Name= "Ayşe", CustomerID="11111", Orders= new List<Order>
        { new Order {OrderID="1", Amount=100},
        new Order {OrderID="2", Amount=300},
        new Order {OrderID="3", Amount=100},
        new Order {OrderID="4", Amount=400},
        new Order {OrderID="5", Amount=50},
        }},

        new Customer{Name= "Ahmet", CustomerID="22222", Orders= new List<Order>
        { new Order {OrderID="6", Amount=100},
        new Order {OrderID="7", Amount=300},
        new Order {OrderID="8", Amount=100},
        new Order {OrderID="9", Amount=400},
        new Order {OrderID="10", Amount=50},
        }},

        new Customer{Name= "Aslı", CustomerID="33333", Orders= new List<Order>
        { new Order {OrderID="11", Amount=100},
        new Order {OrderID="12", Amount=300},
        }},

        new Customer{Name= "Mehmet", CustomerID="44444", Orders= new List<Order>
        { new Order {OrderID="13", Amount=100},
        new Order {OrderID="14", Amount=300}
        }},
    };

    var customersID22222 = customers.Where(x => x.CustomerID == "22222").ToList();
    decimal totalAmount = 0;
    foreach (var item in customersID22222)
    {
        Console.WriteLine("Müşteri ismi: " + item.Name);

        foreach (var i in item.Orders)
        {
            Console.WriteLine("Order ID : " + i.OrderID);
            Console.WriteLine("Order Amount : " + i.Amount);
            totalAmount += i.Amount;
        }

    }
    Console.WriteLine("---------------");
    var customersID22222TotalAmount = customersID22222
                                    .SelectMany(x => x.Orders)
                                    .Sum(x => x.Amount);
    Console.WriteLine("Customer Id= 22222 olan müşterinin Total ödediği tutar: " + customersID22222TotalAmount);
    Console.WriteLine(totalAmount); //alternatif
    Console.WriteLine("---------------");

    Console.WriteLine("Tüm siparişler arasında toplam sipariş tutarını bul.");
    var totalAmountOfAllSales = customers.SelectMany(x => x.Orders).Sum(x => x.Amount);
    Console.WriteLine(totalAmountOfAllSales);
    Console.WriteLine("---------------");

    /*Console.WriteLine("En çok sipariş veren müşteriyi bul.");
    var theBestCustomer= customers.GroupBy(x=>x.CustomerID)
    .SelectMany(x=>x.Orders).Sum(x=>x.Amount)
    Console.WriteLine("---------------");*/



}