using System;

namespace UI
{
    public class MainMenu : IMenu
    {
        public void start()
        {
            bool exit = false;
            string input = "";
            do
            {
               Console.WriteLine("Welcome to the Shoppe");
               Console.WriteLine("What would you like to do?");
               Console.WriteLine("[1]See Brands");
               Console.WriteLine("[2]See Cart");
               Console.WriteLine("[3]History");
               Console.WriteLine("[x]Leave");

               input = Console.ReadLine();

               switch (input)
               {
                   case "1":
                   //Console.WriteLine("shops");
                   new BrandMenu().start();
                   break;

                   case "2":
                   //Console.WriteLine("cart");
                   new CartMenu().start();
                   break;

                   case "3":

                   break;

                   case "x":
                    Console.WriteLine("Bye Bye");
                    exit = true;
                    break;
               }

                
            }while (!exit);

        }

    }
}