using System;
using StoreBL;
using System.Collections.Generic;
using Model = Models;
using Entity = DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace UI
{
    public class Cardboard : IMenu
    {
        private BLI _bl;
        public Cardboard(BLI bl)
        {
            _bl = bl;
        }
        public void Start()
        {

            bool exit = false;
            do
            {
                Console.WriteLine("Welcome to Cardboard Bros");
                Console.WriteLine("[1] See Products");
                Console.WriteLine("[2] Add Item(s) to Cart");
                Console.WriteLine("[3] Edit Inventory");
                Console.WriteLine("[x] Back");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewInventory();
                        break;

                    case "2":
                        break;

                    case "3":
                        EditInventory();
                        break;

                    case "x":
                        exit = true;
                        break;
                }
            } while (!exit);
        }

        private void ViewInventory()
        {
            List<Model.Product> fullInv = _bl.GetInventory();
            if (fullInv.Count == 0)
            {
                Console.WriteLine("No Products");
            }
            else
            {
                foreach (Model.Product prod in fullInv)
                {
                    Console.WriteLine(prod.ToString());
                }
            }
        }

        private void EditInventory()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("[1] Create new Product");
                Console.WriteLine("[2] Restock a Product");
                Console.WriteLine("[3] Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    CreateProduct();
                    break;

                    case "2":
                    break;

                    case "3":
                    exit = true;
                    break;
                }
            } while (!exit);
        }

        private void ViewInventory()
        {
            List<Model.Product> setInventory = _bl.ViewProducts("C");
            if(setInventory.Count == 0)
            {
                Console.WriteLine("Nothing here");
            }
            else
            {
                foreach(Models.Product product in setInventory)
                Console.WriteLine(product);
            }

        }

        private void CreateProduct()
        {
            Product newProd = new Product();

            Console.WriteLine("Please Enter Item Name");
            newProd.Name = Console.ReadLine();

            Console.WriteLine("Identifying Character");
            newProd.Ch = Console.ReadLine();

            Console.WriteLine("Please Enter the Price");
            newProd.ProdPrice = Console.ReadLine();

            Console.WriteLine("Please Enter Current Stock");
            newProd.ProdStock = Console.ReadLine();

            Console.WriteLine("Store Number");
            newProd.StoreId = Console.ReadLine();
            Product addProd = _bl.AddProduct();
            
        }



    }
}
