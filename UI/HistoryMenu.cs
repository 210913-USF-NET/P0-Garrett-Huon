using System;
using StoreBL;

namespace UI
{
    public class HistoryMenu : IMenu
    {

        public HistoryMenu(BLI bl)
        {

        }
        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Here is your shopping history");
                Console.WriteLine("[x] Back to Main Menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "x":
                    exit = true;
                    break;
                }
            }while (!exit);
        }

    }
}