using System.Collections.Generic;
using Models;
using DL;
using System;

namespace StoreBL
{
    public class BL : BLI
    {

        private IRep _repo;

        public BL(IRep repo)
        {
            _repo = repo;
        }

        public List<Customers> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public Customers AddCustomers(Customers cust)
        {
            return _repo.AddCustomers(cust);
        }

        public List<Product> GetInventory()
        {
            return _repo.GetInventory();
        }

        public Product AddProduct(Product prod)
        {
            return _repo.AddProduct(prod);
        }

    }
}
