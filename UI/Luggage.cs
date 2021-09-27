using System;
using StoreBL;

namespace UI
{
    public class Luggage : IMenu
    {
        public Luggage(BLI bl)
        {
            
        }
        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Welcome to Luggin'It Around");
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
            }while (!exit);
            

        }


        private void ViewInventory()
        {
            List<Model.Product> setInventory = _bl.ViewProducts("L");
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