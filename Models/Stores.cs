namespace Models
{
    public class Stores
    {
        public Stores()
        {

        }

        //Creating Customer Details
        public Stores(string name) : this()
        {
            this.Name = name;
        }
        public Stores(string name, string address, string email, string city, string state) : this(name)
        {
            this.Address = address;
            this.Email = email;
            this.City = city;
            this.State = state;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}