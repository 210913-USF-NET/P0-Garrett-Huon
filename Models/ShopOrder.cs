namespace Models
{
    public class ShopOrder
    {
        // private long _total;
        public ShopOrder()
        {
            
        }

        //Creating Customer Details
        public ShopOrder(string address) : this()
        {
            this.Address = address;
        }
        public ShopOrder(string address, string payment) : this(address)
        {
            this.Payment = payment;
        }
        // public long Total()
        // {
        //     _total = value;
        //     value = ShopOrder.Total;
        // }

        public string Address {get; set;}
        public string Payment {get; set;}


    }
}