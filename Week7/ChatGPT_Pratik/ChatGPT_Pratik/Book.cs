namespace ChatGPT_Pratik
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }
        public string Category { get; set; }


        public void DisplayBookInfo()
        {
            Console.WriteLine("Kitabın adı: " + Title);
            Console.WriteLine("Kitabın yazarı: " + Author);
            Console.WriteLine("Kitabın kategori: " + Category);
        }
    }
}