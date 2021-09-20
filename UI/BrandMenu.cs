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
            Console.WriteLine("[4] Brand 4");
            Console.WriteLine("[5] Brand 5");
            Console.WriteLine("[x] Back");
            string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                    MenuFactory.GetMenu("one").Start();
                    break;

                    case "2":
                    MenuFactory.GetMenu("two").Start();
                    break;

                    case "3":
                    MenuFactory.GetMenu("three").Start();
                    break;

                    case "4":
                    MenuFactory.GetMenu("four").Start();
                    break;

                    case "5":
                    MenuFactory.GetMenu("five").Start();
                    break;

                    case "x":
                    exit = true;
                    break;
                }
            }while (!exit);

        }
    }
}