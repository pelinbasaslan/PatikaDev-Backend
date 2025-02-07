namespace ChatGPT_Pratik
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public void DisplayInfoProducts()
        {
            Console.WriteLine("ürün adı: " + Name);
            Console.WriteLine("ürün ücreti: " + Price);
            Console.WriteLine("ürün stok durumu: " + Stock);
        }
    }
}