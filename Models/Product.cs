using System;

namespace Models
{
    public class Product
    {
        private int _stock;
        public decimal ProdPrice {get; set;}
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
        public string Ch {get; set;}
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
       
        public int StoreId {get; set;}
        

        public override string ToString()
        {
            return $"Id: {this.Id}, Ch: {this.Ch}, ProdName:{this.ProdName}, ProdPrice: {this.ProdPrice}, ProdStock: {this.ProdStock}, StoreId: {this.StoreId}";
        }
        public bool Equals(Product product)
        {
            return this.ProdName == product.ProdName && this.Ch == product.Ch &&this.ProdPrice == product.ProdPrice && this.ProdStock == product.ProdStock && this.StoreId == product.StoreId;
        }
    }

    
}