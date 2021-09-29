using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Serilog;


namespace Models
{
    public class ShopOrder
    {
        private decimal _cost;
        public ShopOrder()
        {
            
        }

        //Creating Customer Details
        public ShopOrder(string address) : this()
        {
            this.Address = address;
        }
        public ShopOrder(string address, string payment, string city, string state, string cname) : this(address)
        {
            this.Payment = payment;
            this.City = city;
            this.State = state;
            this.CName = cname;
        }
        
        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                Regex pattern = new Regex("^[0-9 .]+$");
                if(value < 0 || value < _cost)
                {
                    InputInvalidException c = new InputInvalidException("Please enter Payment amount");
                    Log.Warning(c.Message);
                    throw c;
                }
                else
                {
                    _cost = value;
                }
            }
        }

        private string _cname;
        public string CName 
        {
            get
            {
                return _cname;
            }
            set
            {
                Regex npattern = new Regex("^[a-zA-Z]+$");
                if(value.Length == 0)
                {
                    InputInvalidException n = new InputInvalidException("Name can't be empty");
                    Log.Warning(n.Message);
                    throw n;
                }
                else
                {
                    _cname = value;
                }
            }

        }
        
        public int Id {get; set;}
        
        public string Address {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public string Payment {get; set;}
        public int LineItemId {get; set;}


        public override string ToString()
        {
            return $"Id: {this.Id}, CName {this.CName}, Address = {this.Address},City = {this.City}, State = {this.State}, Payment = {this.Payment}, Cost = {this.Cost}, LineItemId = {this.LineItemId}";
        }
        public bool Equals(ShopOrder order)
        {
            return this.CName == order.CName && this.Address == order.Address && this.City == order.City && this.State == order.State && this.Payment == order.Payment && this.Cost == order.Cost && this.LineItemId == order.LineItemId;
        }
        
    }
}