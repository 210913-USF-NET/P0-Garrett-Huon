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
        List<Product> ViewProducts(string queryStr);
        Product GetProdById(int id);
        Product UpdateItem(Product itemToUpdate);
        LineItem AddItemToCart(LineItem cartItem);
        List<LineItem> GetLineItem();
        List<Product> GetInventory();
        ShopOrder AddOrder(ShopOrder order);

        List<ShopOrder> SearchForOrder(string queryStr);

        ShopOrder GetOrderById(int id);

        List<ShopOrder> GetAllOrders();
    }
        
}