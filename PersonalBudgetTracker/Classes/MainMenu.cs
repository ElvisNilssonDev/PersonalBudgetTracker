using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTracker.Classes
{
    internal class MainMenu
    {
        public class MenuHelper
        {
            public static void ShowMainMenu()
            {
                Transaction transaction = new Transaction();
                bool running = true;

                while (running)
                {
                    Console.WriteLine("\n ===Welcome To The Personal Budget Tracker=== ");
                    Console.WriteLine("1. ===Add transaction===");
                    Console.WriteLine("2. ===Show all transactions===");
                    Console.WriteLine("3. ===Show balance===");
                    Console.WriteLine("4. ===Delete a transaction===");
                    Console.WriteLine("5. ===End Program===");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine()!;

                    switch (choice)
                    {
                        case "1":
                            // add transaction
                            break;

                        case "2":
                            // add show all trans
                            break;

                        case "3":
                            // add show balance
                            break;

                        case "4":
                            // add delete a trans
                            break;

                        case "5":
                            Console.WriteLine("Exiting BudgetTracker...");
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Something went wrong!!...");
                            break;

                    }
                } // add a menu extra
            }
        }
    }
}
