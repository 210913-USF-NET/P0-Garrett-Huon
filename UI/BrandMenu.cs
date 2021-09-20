using System;
using Models;
using StoreBL;

namespace UI
{
    public class BrandMenu : IMenu
    {
        public BrandMenu(BLI bl)
        {

        }
        public void Start()
        {
            bool exit = false;
            do{
            Console.WriteLine("Here are your store options:");
            Console.WriteLine("[1] Lays");
            Console.WriteLine("[2] Brand 2");
            Console.WriteLine("[3] Brand 3");
            Console.WriteLine("[x] Back");

                switch(Console.ReadLine())
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