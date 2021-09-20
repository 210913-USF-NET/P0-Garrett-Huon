using System;

namespace Models
{
    public class Customers
    {

        public Customers()
        {
            
        }
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
        
    }
}