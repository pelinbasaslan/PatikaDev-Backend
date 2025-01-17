using System.ComponentModel;

//Sinema Filmlerini listeleyeceğimiz bir liste oluşturalım.
List<Movies> moviesList = new List<Movies>();

while (true)
{
    //Kullanıcıdan sınırsız sayıda film adı ve imdb puanı isteyip bu bilgilerle nesneler oluşturulup liste doldurulacak.
    Movies movies = new Movies();
    Console.Write("Film Adı:");
    movies.Name = Console.ReadLine();
    Console.Write(movies.Name + " adlı filmin Imdb Puanı:");
    movies.ImdbRating = Convert.ToDouble(Console.ReadLine());

    moviesList.Add(movies);

    // Kullanıcıya her film eklemesinden sonra yeni bir film eklemek isteyip istemediği sorulsun. Kullanıcı evet cevabını verirse döngüde başa dönülerek yeni bir film oluşturulup ilgili listeye aktarılsın. 
    Console.WriteLine("Başka bir film eklemek ister misiniz? (e/h)");
    string continueProgram = Console.ReadLine().ToLower();
    if (continueProgram != "e")
        break;
}
Console.WriteLine("---------------------");

// 1)Bütün filmler listelensin.
Console.WriteLine("Filmler:");
int index = 1;
foreach (var item in moviesList)
{
    Console.WriteLine(index + ") " + item.Name);
}
Console.WriteLine("---------------------");

//2)Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin.
Console.WriteLine("Imdb puanı 4 ile 9 arasında olan bütün filmler:");
foreach (var item in moviesList)
{
    if (item.ImdbRating >= 4 && item.ImdbRating <= 9)
    {
        Console.WriteLine(item.Name + " isimli filmin Imdb puanı: " + item.ImdbRating);
    }
    else
    {
        Console.WriteLine("Imdb puanı 4 ile 9 arasında film yok.");
    }
}
Console.WriteLine("---------------------");

//İsmi 'A' ile başlayan filmler ve imdb puanları listelensin.
Console.WriteLine("İsmi 'A' ile başlayan filmler:");
foreach (var item in moviesList)
{
    if (item.Name.Substring(0, 1).ToUpper() == "A")
    {
        Console.WriteLine(item.Name);
    }
    else
    {
        Console.WriteLine("İsmi 'A' ile başlayan film yok.");
    }

}
Console.WriteLine("---------------------");





