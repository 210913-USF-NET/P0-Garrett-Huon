using DL;
using StoreBL;

namespace UI
{
    public class MenuFactory
    {
        public static IMenu GetMenu(string menuString)
        {
            //this is an example of dependency injection
            //I'm "injecting" an instance of business logic layer to restaurant menu, and an implementation of 
            //IRepo to business logic
            // IRepo dataLayer = new FileRepo();
            // IBL businessLogic = new BL(dataLayer);
            // IMenu restaurantMenu = new RestaurantMenu(businessLogic);

            // restaurantMenu.Start();
            switch (menuString.ToLower())
            {
                case "login":
                    return new LoginMenu();
                case "main":
                    return new MainMenu(new BL(new FileRepo()));
                case "brand":
                    return new BrandMenu(new BL(new FileRepo()));
                case "cart":
                    return new CartMenu(new BL(new FileRepo()));    
                case "history":
                    return new HistoryMenu(new BL(new FileRepo())); 
                default:
                    return null;
            }
        }
    }
}