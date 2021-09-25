using System;
using StoreBL;
using System.Collections.Generic;
using Model = Models;
using Entity = DL.Entities;
using Microsoft.EntityFrameworkCore;


namespace UI
{
    public class Bags : IMenu
    {
        private BLI _bl;
        public Bags(BLI bl)
        {
            _bl = bl;
        }
        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Welcome to BRAND");
                Console.WriteLine("[1] See Products");
                Console.WriteLine("[2] Add Item(s) to Cart");
                Console.WriteLine("[x] Back");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    ViewInventory();
                    break;

                    case "2":
                    break;

                    case "x":
                    exit = true;
                    break;
                }
            }while (!exit);
            

        }

        private void ViewInventory()
        {
            List<Model.Product> fullInv = _bl.GetInventory(StoreId=1);
            if(fullInv.Count == 0)
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
    }
}