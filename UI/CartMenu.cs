using System;

namespace UI
{
    public class CartMenu : IMenu
    {
        public CartMenu()
        {

        }
         public void start()
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

             switch (Console.ReadLine())
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