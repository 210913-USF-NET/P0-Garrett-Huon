using System.Collections.Generic;
using Models;
using DL;

namespace StoreBL
{
    public interface BLI
    {
        Customers AddCustomers(Customers cust);
        List<Customers> GetCustomers();
        List<Product> GetInventory();
    }
}