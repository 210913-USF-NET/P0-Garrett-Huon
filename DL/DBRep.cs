using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model = Models;
using Entity = DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DL
{
    public class DBRep : IRep
    {
        private Entity.ProjZeroOneContext _context;
        public DBRep(Entity.ProjZeroOneContext context)
        {
            _context = context;
        }


        //Customer Services///
        public Model.Customers AddCustomers(Model.Customers cust)
        {
            Entity.Customer custAdd = new Entity.Customer()
            {
                Name = cust.Name,
                Email= cust.Email ?? ""
            };
            custAdd = _context.Add(custAdd).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
            
            return new Model.Customers()
            {
                Id = custAdd.Id,
                Name = custAdd.Name,
                Email = custAdd.Email
            };
        }

        public List<Model.Customers> GetCustomers()
        {
            return _context.Customers.Select(
                customer => new Model.Customers(){
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email
                    
                }
            ).ToList();

        }
        public Model.Product AddProduct(Model.Product prod)
        {
            Entity.StoreInv prodAdd = new Entity.StoreInv()
            {
                ProdName = prod.ProdName,
                ProdPrice = prod.ProdPrice,
                ProdStock = prod.ProdStock
            };
            prodAdd = _context.Add(prodAdd).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
            
            return new Model.Product()
            {
                Id = prodAdd.Id,
                ProdName = prodAdd.ProdName,
                ProdPrice = prodAdd.ProdPrice,
                ProdStock = prodAdd.ProdStock
            };
        }
        public List<Model.Product> GetInventory()
        {
            return _context.StoreInvs.Select(
                nProd => new Model.Product(){
                    Id = nProd.Id,
                    ProdName = nProd.ProdName,
                    ProdPrice = nProd.ProdPrice,
                    ProdStock = nProd.ProdStock
                    
                }
            ).ToList();

        }




    }
}