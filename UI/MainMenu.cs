using System;
using StoreBL;
using Models;
using DL;

namespace UI
{
    public class MainMenu : IMenu
    {

        
        public MainMenu(BLI bl)
        {
            
        }
        public void Start()
        {
            bool exit = false;
            do
            {
               Console.WriteLine("Welcome to the Shoppe");
               Console.WriteLine("What would you like to do?");
               Console.WriteLine("[1]See Brands");
               Console.WriteLine("[2]See Cart");
               Console.WriteLine("[3]History");
               Console.WriteLine("[x]Leave");

               string input = Console.ReadLine();

               switch (input)
               {
                   case "1":
                   //Console.WriteLine("shops");
                   MenuFactory.GetMenu("brand").Start();
                   break;

                   case "2":
                   //Console.WriteLine("cart");
                   MenuFactory.GetMenu("cart").Start();
                   break;

                   case "3":
                   MenuFactory.GetMenu("history").Start();
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