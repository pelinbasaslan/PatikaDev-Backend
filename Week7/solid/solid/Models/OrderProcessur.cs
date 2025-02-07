namespace solid
{


    internal class OrderProcessur
    {
        private readonly EmailSenders _sender;
        public OrderProcessur(EmailSenders senders)
        {
            _sender = senders;
        }
        public void ProcessOrder(string orderDetail)
        {
            Console.WriteLine("Processing order" + orderDetail);
        }


        // bu email olanı farklı sınıf yap karışmasın diyor SOLID prensip..!!!!
        /*
               public void SendOrderConfirmasion(string orderDetail)
               {
                Console.WriteLine("Sending confirmation email");
               }
        */

    }

}