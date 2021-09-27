using System;
using StoreBL;
using Models;
using System.Collections.Generic;
using DL;
using Entity = DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace UI
{
    public class MainMenu : IMenu
    {
        private BLI _bl;
        public MainMenu(BLI bl)
        {
            _bl = bl;
        }
        public void Start()
        {

            bool alreadyLog = false;
            bool exit = false;
            do
            {
                if (!alreadyLog)
                {
                    Console.WriteLine("Please Log In");
                    CreateCustomer();
                    alreadyLog = true;
                }
                
                Console.WriteLine($"Hello");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[1]See Stores");
                Console.WriteLine("[2]See Cart");
                Console.WriteLine("[3]History");
                Console.WriteLine("[x]Leave");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        MenuFactory.GetMenu("stores").Start();
                        break;

                    case "2":
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


            } while (!exit);

        }
        private void CreateCustomer()
        {
            Customers newCustomer = new Customers();

            Console.WriteLine("Please Enter Your Name");
            newCustomer.Name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Email");
            newCustomer.Email = Console.ReadLine();
            Customers addedCust = _bl.AddCustomers(newCustomer);

            
        }




    }
}