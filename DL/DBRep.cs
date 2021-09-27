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
                Email = cust.Email ?? ""
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
                customer => new Model.Customers()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email
                    

                }
            ).ToList();

        }
        public List<Model.Customers> SearchACustomer(string queryStr)
        {
            return _context.Customers.Where(
                cust => cust.Name.Contains(queryStr) || cust.Email.Contains(queryStr)
            ).Select(
                r => new Model.Customers(){
                    Id = r.Id,
                    Name = r.Name,
                    Email = r.Email
                    
                }
            ).ToList();
        }

        public Model.Product AddProduct(Model.Product prod)
        {
            Entity.StoreInv prodAdd = new Entity.StoreInv()
            {
                Ch = prod.Ch,
                ProdName = prod.ProdName,
                ProdPrice = prod.ProdPrice,
                ProdStock = prod.ProdStock,
                StoreId = prod.StoreId
            };
            prodAdd = _context.Add(prodAdd).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

            return new Model.Product()
            {
                Id = prodAdd.Id,
                Ch = prodAdd.Ch,
                ProdName = prodAdd.ProdName,
                ProdPrice = prodAdd.ProdPrice,
                ProdStock = prodAdd.ProdStock,
                StoreId = prodAdd.StoreId
            };
        }
        public List<Model.Product> GetInventory()
        {

            return _context.StoreInvs.Select(
                nProd => new Model.Product()
                {
                    Id = nProd.Id,
                    Ch = nProd.Ch,
                    ProdName = nProd.ProdName,
                    ProdPrice = nProd.ProdPrice,
                    ProdStock = nProd.ProdStock,
                    StoreId = nProd.StoreId

                }
        ).ToList();
        }

         public Model.Customers GetCustomerById(int id)
        {
            Entity.Customer custById = 
                _context.Customers
                .FirstOrDefault(r => r.Id == id);

            return new Model.Customers() {
                Id = custById.Id,
                Name = custById.Name,
                Email = custById.Email
                
            };
        }

        public List<Model.Product> ViewProducts(string queryStr)
        {
            return _context.StoreInvs.Where(
                prod => prod.Ch.Contains(queryStr)
            ).Select(
                r => new Model.Product(){
                    Id = r.Id,
                    Ch = r.Ch,
                    ProdName = r.ProdName,
                    ProdPrice = r.ProdPrice,
                    ProdStock = r.ProdStock,
                    StoreId = r.StoreId
                }
            ).ToList();
        }

        



    }
}