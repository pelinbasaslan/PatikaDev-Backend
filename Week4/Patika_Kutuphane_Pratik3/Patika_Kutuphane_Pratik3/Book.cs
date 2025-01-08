public class Book
// Kitap nesnesi oluşturdum Classla. 
//Sınıf (Class), nesne tabanlı programlamanın temel yapı taşlarındandır.
//Bir class tanımladığında, aslında bu sınıfı kullanan nesnelerin özelliklerini ve bu özelliklerle yapılacak işlemleri belirlemiş olunur.
{
    public string Name { get; set; } //Property 
    public string AuthorsName { get; set; } //Property
    public string AuthorsSurName { get; set; } //Property
    public int TotalPage { get; set; } //Property
    public string Publisher { get; set; }   //Property
    public DateTime DateOfRecord { get; set; } //Property

    //Property: Bir sınıfın verilerini (değerlerini) kapsayan özel alanlardır. 

    public Book() //Constructor, no parameters.
    {
        DateOfRecord = DateTime.Now; 
    }

    public Book(string name, string authorsName, string authorsSurName, int totalPage, string publisher) 
    //Constructor && with parameters, assigns these values during object creation.
    {
        Name = name;
        AuthorsName = authorsName;
        AuthorsSurName = authorsSurName;
        TotalPage= totalPage;
        Publisher = publisher;
        DateOfRecord = DateTime.Now;
        
    }

    public Book(string name) //Constructor
    {
        Name = name;
        DateOfRecord = DateTime.Now;
    }

    public Book(string authorsName, string authorsSurName)
    {
        AuthorsName = authorsName;
        AuthorsSurName = authorsSurName; 
        DateOfRecord = DateTime.Now; 
    }
    //Constructor:  C#'ta nesne yönelimli programlamada constructor (yapıcı metot), bir sınıfın yeni bir nesnesi oluşturulduğunda otomatik ve zorunlu olarak çağrılan ve sınıfın başlangıç durumunu belirlemek için kullanılan özel bir metottur.

    public void KitabiTanit()
    { 
        Console.WriteLine($"Kitap adı: {Name}, Yazar Adı ve Soyadı : {AuthorsName} {AuthorsSurName}, Sayfa Sayısı: {TotalPage}, Yayınevi: {Publisher}, Kayıt tarihi: {DateOfRecord}."); 
    }
}