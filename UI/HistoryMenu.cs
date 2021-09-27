using System;
using StoreBL;
using Models;
using System.Collections.Generic;


namespace UI
{
    public class HistoryMenu : IMenu
    {
        private BLI _bl;
        private ShoppesService _shoppeservice;

        public HistoryMenu(BLI bl, ShoppesService shoppeservice)
        {
            _bl = bl;
            _shoppeservice = shoppeservice;

        }
        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Here is your shopping history");
                Console.WriteLine("[1] View All Customers");
                Console.WriteLine("[2] Search Customer");
                Console.WriteLine("[x] Back to Main Menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    ViewCustomerList(); 
                    break;

                    case "2":
                    SearchCustomer();
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

        private void SearchCustomer()
        {
            //First, I'm going to ask for user to gimme a search term to search for
            //once they select the restaurant
            //I'm going to grab the restaurant
            //and its reviews and display them to user
            Console.WriteLine("Search for Customer");
            List<Customers> searchResult = _bl.SearchACustomer(Console.ReadLine());
            if(searchResult == null || searchResult.Count == 0)
            {
                Console.WriteLine("No one like that exists in this system.");
                return;
            }
            Customers selectedCustomer = _shoppeservice.SelectACustomer("Pick Customer", searchResult);

            selectedCustomer = _bl.GetCustomerById(selectedCustomer.Id);
            Console.WriteLine(selectedCustomer);
            // foreach(Review review in selectedRestaurant.Reviews)
            // {
            //     Console.WriteLine(review);
            // }
            
        }

    }
}