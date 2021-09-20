using System;
using System.Collections.Generic;
using StoreBL;
using DL;
using Models;


namespace UI
{
    public class LoginMenu : IMenu
    {
        public void Start()
        {
            bool exit = false;
            do{
            Console.WriteLine("Welcome to EShoppe");
            Console.WriteLine("[y] To Log In");
            Console.WriteLine("[x]To exit");

                switch (Console.ReadLine())
                {
                    case "y":

                    Customers newCustomer = new Customers();

                    Console.WriteLine("Please Enter Your Name");
                    string name = Console.ReadLine();
                    Console.WriteLine($"Thank you, {newCustomer.Name}");


                    Console.WriteLine("Please Enter Your Email");
                    newCustomer.Email = Console.ReadLine();
                    MenuFactory.GetMenu("main").Start();

                    break;

                    case "x":
                    exit = true;
                    break;

                }
            }while (!exit);
        
        }


                
                

           
        
    }
}