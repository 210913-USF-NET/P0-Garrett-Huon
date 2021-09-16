using System;

namespace UI
{
    public class MainMenu
    {
        public void start()
        {
            bool exit = false;
            string input = "";
            do{
               Console.WriteLine("Welcome to the Shoppe");
               Console.WriteLine("What would you like to do?");
               Console.WriteLine("[1]");
               Console.WriteLine("[2]");

               input = Console.ReadLine();

            } while (!exit);


            
        }


        
    }
}