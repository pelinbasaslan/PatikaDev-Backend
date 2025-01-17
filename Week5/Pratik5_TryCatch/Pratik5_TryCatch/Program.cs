sayi: try
{
    Console.Write("Bir sayı giriniz:");
    double num = Convert.ToDouble(Console.ReadLine());
    double square = Math.Pow(num, 2);
    Console.WriteLine($"Girilen sayı {num} karesi: {square}");

}
catch (System.Exception)
{
    Console.WriteLine("Geçersiz giriş.");
    goto sayi;
}