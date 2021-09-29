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

        //User/Customer function
        public List<Customers> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public Customers AddCustomers(Customers cust)
        {
            return _repo.AddCustomers(cust);
        }
        public List<Customers> SearchACustomer(string queryStr)
        {
            return _repo.SearchACustomer(queryStr);
        }

        public Customers GetCustomerById(int id)
        {
            return _repo.GetCustomerById(id);

        }

        //Products and Items

        public Product AddProduct(Product prod)
        {
            return _repo.AddProduct(prod);
        }

        public List<Product> ViewProducts(string queryStr)
        {
            return _repo.ViewProducts(queryStr);
        }

        public Product GetProdById(int id)
        {
            return _repo.GetProdById(id);

        }

        public Product UpdateItem(Product itemToUpdate)
        {
            return _repo.UpdateItem(itemToUpdate);
        }

        public LineItem AddItemToCart(LineItem cartItem)
        {
            return _repo.AddItemToCart(cartItem);
        }

        public List<LineItem> GetLineItem()
        {
            return _repo.GetLineItem();
        }

        public List<Product> GetInventory()
        {
            return _repo.GetInventory();
        }

        public ShopOrder AddOrder(ShopOrder order)
        {
            return _repo.AddOrder(order);
        }

        public List<ShopOrder> SearchForOrder(string queryStr)
        {
            return _repo.SearchForOrder(queryStr);
        }

        public ShopOrder GetOrderById(int id)
        {
            return _repo.GetOrderById(id);
        }

        public List<ShopOrder> GetAllOrders()
        {
            return _repo.GetAllOrders();
        }
      
    }
}
