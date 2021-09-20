using System;
using StoreBL;

namespace UI
{
    public class BrandFour : IMenu
    {
        public BrandFour(BLI bl)
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
                Console.WriteLine("[x] Back");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    break;

                    case "2":
                    break;

                    case "x":
                    exit = true;
                    break;
                }
            }while (!exit);
            

        }
    }
}