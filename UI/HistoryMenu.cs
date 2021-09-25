using System;
using StoreBL;
using Models;
using System.Collections.Generic;


namespace UI
{
    public class HistoryMenu : IMenu
    {
        private BLI _bl;

        public HistoryMenu(BLI bl)
        {
            _bl = bl;

        }
        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Here is your shopping history");
                Console.WriteLine("[1] View All Customers");
                Console.WriteLine("[x] Back to Main Menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    ViewCustomerList(); 
                    break;
                    case "x":
                    exit = true;
                    break;
                }
            }while (!exit);
        }

        private void ViewCustomerList()
        {
            List<Customers> allCust = _bl.GetCustomers();
            if(allCust.Count == 0)
            {
                Console.WriteLine("No Customers");
            }
            else
            {
                foreach (Customers cust in allCust)
                {
                    Console.WriteLine(cust.ToString());
                }
            }
        }

        

    }
}