using Models;
using System.Collections.Generic;

namespace DL
{
    public interface IRep
    {
         Customers AddCustomers(Customers cust);
         List<Customers> GetCustomers();
         //List<Customers> SearchCustomer(string queryStr);
         List<Product> GetInventory();

         Product AddProduct(Product prod);
    }
}