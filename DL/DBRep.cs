using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model = Models;
using Entity = DL.Entities;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DL
{
    public class DBRep : IRep
    {
        private Entity.ProjZeroONeContext _context;
        public DBRep(Entity.ProjZeroONeContext context)
        {
            _context = context;
        }



        //Customer Services///
        
        /// <summary>
        /// Create Customer
        /// </summary>
        /// <param name="cust"></param>
        /// <returns>Model.Customers</returns>
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
        /// <summary>
        /// Get List of Customers
        /// </summary>
        /// <returns>All Model.Customers</returns>
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
                r => new Model.Customers()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Email = r.Email

                }
            ).ToList();
        }

        public Model.Customers GetCustomerById(int id)
        {
            Entity.Customer custById =
                _context.Customers
                .FirstOrDefault(r => r.Id == id);

            return new Model.Customers()
            {
                Id = custById.Id,
                Name = custById.Name,
                Email = custById.Email

            };
        }


        //Product and Store Stuff
        /// <summary>
        /// Create New Product
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>Model.Product</returns>
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

        /// <summary>
        /// Used to get inventory of specific store
        /// </summary>
        /// <param name="queryStr"></param>
        /// <returns>Model.Product specified with Ch value</returns>
        public List<Model.Product> ViewProducts(string queryStr)
        {
            return _context.StoreInvs.Where(
                prod => prod.Ch.Contains(queryStr)
            ).Select(
                r => new Model.Product()
                {
                    Id = r.Id,
                    Ch = r.Ch,
                    ProdName = r.ProdName,
                    ProdPrice = r.ProdPrice,
                    ProdStock = r.ProdStock,
                    StoreId = r.StoreId
                }
            ).ToList();
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>All Model.Product</returns>
        public List<Model.Product> GetInventory()
        {
            return _context.StoreInvs.Select(
                prod => new Model.Product()
                {
                    Id = prod.Id,
                    Ch = prod.Ch,
                    ProdName = prod.ProdName,
                    ProdPrice = prod.ProdPrice,
                    ProdStock = prod.ProdStock,
                    StoreId = prod.StoreId


                }
            ).ToList();

        }

        public Model.Product GetProdById(int id)
        {
            Entity.StoreInv prodById =
                _context.StoreInvs
                .FirstOrDefault(r => r.Id == id);

            return new Model.Product()
            {
                Id = prodById.Id,
                Ch = prodById.Ch,
                ProdName = prodById.ProdName,
                ProdPrice = prodById.ProdPrice,
                ProdStock = prodById.ProdStock,
                StoreId = prodById.StoreId

            };
        }

        public Model.Product UpdateItem(Model.Product itemToUpdate)
        {
            Entity.StoreInv itemUpdate = new Entity.StoreInv()
            {
                Id = itemToUpdate.Id,
                Ch = itemToUpdate.Ch,
                ProdName = itemToUpdate.ProdName,
                ProdPrice = itemToUpdate.ProdPrice,
                ProdStock = itemToUpdate.ProdStock,
                StoreId = itemToUpdate.StoreId
            };

            itemUpdate = _context.StoreInvs.Update(itemUpdate).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

            return new Model.Product()
            {
                Id = itemUpdate.Id,
                Ch = itemUpdate.Ch,
                ProdName = itemUpdate.ProdName,
                ProdPrice = itemUpdate.ProdPrice,
                ProdStock = itemUpdate.ProdStock,
                StoreId = itemUpdate.StoreId
            };
        }
        /// <summary>
        /// Was used as temp Cart but now adds to Line Item Table
        /// </summary>
        /// <param name="cartItem"></param>
        /// <returns>Model.LineItem</returns>
        public Model.LineItem AddItemToCart(Model.LineItem cartItem)
        {
            Entity.LineItem itemInCart = new Entity.LineItem()
            {
                Id = cartItem.Id,
                Quant = cartItem.Quant,
                StoreId = cartItem.StoreId,
                ProdId = cartItem.ProdId
            };
            itemInCart = _context.Add(itemInCart).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

            return new Model.LineItem()
            {
                Id = itemInCart.Id,
                Quant = itemInCart.Quant,
                StoreId = itemInCart.StoreId,
                ProdId = Convert.ToInt32(itemInCart.ProdId)
            };
        }
        /// <summary>
        /// Show all Line Items
        /// </summary>
        /// <returns>All Model.LineItem</returns>
        public List<Model.LineItem> GetLineItem()
        {
            return _context.LineItems.Select(
                cItem => new Model.LineItem()
                {
                    Id = cItem.Id,
                    Quant = cItem.Quant,
                    StoreId = cItem.StoreId,
                    ProdId = Convert.ToInt32(cItem.ProdId),


                }
            ).ToList();
        }
        /// <summary>
        /// Creates new order
        /// </summary>
        /// <param name="order"></param>
        /// <returns>Model.ShopOrder</returns>

        public Model.ShopOrder AddOrder(Model.ShopOrder order)
        {
            Entity.ShopOrder orderAdd = new Entity.ShopOrder()
            {
                Cname = order.CName,
                Address = order.Address,
                City = order.City,
                State = order.State,
                Payment = order.Payment,
                LineId = order.LineItemId,
                Cost = order.Cost
            };
            orderAdd = _context.Add(orderAdd).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

            return new Model.ShopOrder()
            {
                Id = order.Id,
                CName = order.CName,
                Address = order.Address,
                City = order.City,
                State = order.State,
                Payment = order.Payment,
                LineItemId = order.LineItemId,
                Cost = order.Cost
            };
        }



        public List<Model.ShopOrder> SearchForOrder(string queryStr)
        {
            return _context.ShopOrders.Where(
                order => order.Cname.Contains(queryStr) || order.Address.Contains(queryStr)|| order.Payment.Contains(queryStr)|| order.City.Contains(queryStr)|| order.State.Contains(queryStr)
            ).Select(
                r => new Model.ShopOrder()
                {
                    Id = r.Id,
                    CName = r.Cname,
                    Address = r.Address,
                    City = r.City,
                    State = r.State,
                    Payment = r.Payment,
                    LineItemId = Convert.ToInt32(r.LineId),
                    Cost = r.Cost

                }
            ).ToList();
        }

        public Model.ShopOrder GetOrderById(int id)
        {
            Entity.ShopOrder orderById =
                _context.ShopOrders
                .FirstOrDefault(r => r.Id == id);

            return new Model.ShopOrder()
            {
                    Id = orderById.Id,
                    CName = orderById.Cname,
                    Address = orderById.Address,
                    City = orderById.City,
                    State = orderById.State,
                    Payment = orderById.Payment,
                    LineItemId = Convert.ToInt32(orderById.LineId),
                    Cost = orderById.Cost

            };
        }


         public List<Model.ShopOrder> GetAllOrders()
        {
            return _context.ShopOrders.Select(
                ord => new Model.ShopOrder()
                {
                    Id = ord.Id,
                    CName = ord.Cname,
                    Address = ord.Address,
                    City = ord.City,
                    State = ord.State,
                    Payment = ord.Payment,
                    LineItemId = Convert.ToInt32(ord.LineId),
                    Cost = ord.Cost


                }
            ).ToList();

        }

       
    }
}