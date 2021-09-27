using Models;
using System.Collections.Generic;

namespace DL
{
    public interface IRep
    {
         Customers AddCustomers(Customers cust);
         List<Customers> GetCustomers();
        
         List<Customers> SearchACustomer(string queryStr);
         Customers GetCustomerById(int id);
         List<Product> GetInventory();

         Product AddProduct(Product prod);

         List<Product> ViewProducts(string queryStr);
        
    }
}