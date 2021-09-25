using System;
using StoreBL;

namespace UI
{
    public class Freight : IMenu
    {
        public Freight(BLI bl)
        {
            
        }
        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Welcome to BRAND");
                Console.WriteLine("[1] See New Products");
                Console.WriteLine("[2] Add Item(s) to Cart");
                Console.WriteLine("[3] Edit Inventory");
                Console.WriteLine("[x] Back");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    break;

                    case "2":
                    break;

                    case "3":
                    break;

                    case "x":
                    exit = true;
                    break;
                }
            }while (!exit);
            

        }
    }
}