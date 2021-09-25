using System;

namespace Models
{
    public class Product
    {
        private int _stock;
        private long _price;
         public Product()
        {
            
        }

        //Creating Product Details
        public Product(string name) : this()
        {
            this.ProdName = name;
        }
        public Product(string name, decimal price) : this(name)
        {
            this.ProdPrice = price;
               
        }
                public string ProdName {get; set;}
        
        public int ProdStock
        {
            get {
                return _stock;
            } 
            set {
                 if(value<0)
                {
                    throw new InputInvalidException("Value cannot be below zero.");
                }
                else
                {
                    _stock = value;
                }

            }
            
        }
        public int Id {get; set;}

        public decimal ProdPrice {get; set;}

        public override string ToString()
        {
            return $"Id: {this.Id}, ProdName {this.ProdName}, ProdPrice = {this.ProdPrice}, ProdStock = {this.ProdStock}";
        }
        public bool Equals(Product product)
        {
            return this.ProdName == product.ProdName && this.ProdPrice == product.ProdPrice && this.ProdStock == product.ProdStock;
        }
    }

    
}