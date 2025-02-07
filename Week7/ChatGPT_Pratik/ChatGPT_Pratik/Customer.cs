namespace ChatGPT_Pratik
{
    public class Customer
    {
        public string Name { get; set; }
        public string CustomerID { get; set; }

        public List<Order> Orders { get; set; }
    }
}