using System.Collections.Generic;
using Models;
using DL;

namespace StoreBL
{
    public interface BLI
    {
        Customers AddCustomers(Customers cust);
        List<Customers> GetCustomers();
        List<Customers> SearchACustomer(string queryStr);
        Customers GetCustomerById(int id);
        Product AddProduct(Product prod);
        List<Product> GetInventory();
        List<Product> ViewProducts(string queryStr);
        
}