using System;

namespace Models
{
    public class Customers
    {

        public Customers()
        {
            
        }

        //Creating Customer Details
        public Customers(string name) : this()
        {
            this.Name = name;
        }
        public Customers(string name, string email) : this(name)
        {
            this.Email = email;
        }
        public string Name {get; set;}
        public string Email {get; set;}
        public int Id {get; set;}
        

        public override string ToString()
        {
            return $"Id: {this.Id}, Name {this.Name}, Email = {this.Email}";
        }
        public bool Equals(Customers customer)
        {
            return this.Name == customer.Name && this.Email == customer.Email;
        }
    }
}