using DL;
using StoreBL;
using DL.Entities;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace UI
{
    public class MenuFactory
    {
        public static IMenu GetMenu(string menuString)
        {
            string connectionString = File.ReadAllText(@"../connectString.txt");
            DbContextOptions<ProjZeroOneContext> options = new DbContextOptionsBuilder<ProjZeroOneContext>()
            .UseSqlServer(connectionString).Options;
            ProjZeroOneContext context = new ProjZeroOneContext(options);

            //this is an example of dependency injection
            //I'm "injecting" an instance of business logic layer to restaurant menu, and an implementation of 
            //IRepo to business logic
            // IRepo dataLayer = new FileRepo();
            // IBL businessLogic = new BL(dataLayer);
            // IMenu restaurantMenu = new RestaurantMenu(businessLogic);

            // restaurantMenu.Start();
            switch (menuString.ToLower())
            {
                //Base Menus
                case "login":
                    return new LoginMenu();

                case "admin":
                    return new AdminMenu(new BL(new DBRep(context)));

                case "main":
                    return new MainMenu(new BL(new DBRep(context)));

                case "history":
                    return new HistoryMenu(new BL(new DBRep(context)), new ShoppesService());    


                //Brand Related    
                case "stores":
                    return new BrandMenu(new BL(new DBRep(context)));

                case "bags":
                    return new Bags(new BL(new DBRep(context)));

                case "cardboard":
                    return new Cardboard(new BL(new DBRep(context)));    

                case "luggage":
                    return new Luggage(new BL(new DBRep(context)));

                case "plastic":
                    return new Plastic(new BL(new DBRep(context)));  

                case "freight":
                    return new Freight(new BL(new DBRep(context)));


                //User Shopping
                case "cart":
                    return new CartMenu(new BL(new DBRep(context))); 



                default:
                    return null;
            }
        }
    }
}