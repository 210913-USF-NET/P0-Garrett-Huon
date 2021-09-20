using System.Collections.Generic;
using Models;
using DL;

namespace StoreBL
{
    public interface BLI
    {
        Customers AddCustomer(Customers customer);
        List<Customers> GetAllCustomers();
         
    }
}