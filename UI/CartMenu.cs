using System;
using Models;
using StoreBL;

namespace UI
{
    public class CartMenu : IMenu
    {
        public CartMenu(BLI bl)
        {

        }
         public void Start()
        {
            bool exit = false;
            do
            {
            Console.WriteLine("Here is your Cart");
            Console.WriteLine("List<ShoppingList>");
            Console.WriteLine("[1] Add Item");
            Console.WriteLine("[2] Remove Item");
            Console.WriteLine("[3] Check Out");
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