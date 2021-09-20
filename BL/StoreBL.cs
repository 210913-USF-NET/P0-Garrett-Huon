using System.Collections.Generic;
using Models;
using DL;
using System;

namespace StoreBL
{
    public class BL : BLI
    {

        private IRepos _repo;

        public BL(IRepos repo)
        {
            _repo = repo;
        }

        public List<Customers> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customers AddCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

    }
}
