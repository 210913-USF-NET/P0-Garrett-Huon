using System;
using StoreBL;


namespace UI
{
    public class AdminMenu : IMenu
    {
         
        public AdminMenu(BLI bl)
        {
            
        }
        public void Start()
        {
            bool exit = false;
            do
            {
               Console.WriteLine("Welcome to Terminal");
               Console.WriteLine("What would you like to do?");
               Console.WriteLine("[1]See Brands");
               Console.WriteLine("[2]See Customers");
               Console.WriteLine("[x]Leave");

               string input = Console.ReadLine();

               switch (input)
               {
                   case "1":
                   MenuFactory.GetMenu("brand").Start();
                   break;

                   case "2":
                   MenuFactory.GetMenu("cart").Start();
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