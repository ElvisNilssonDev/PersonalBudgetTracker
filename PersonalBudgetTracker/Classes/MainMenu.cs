using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonalBudgetTracker.Classes
{
    public class MainMenu
    {
        
            public static void ShowMainMenu()
            {

                BudgetManager manager = new BudgetManager();
                bool running = true;

                while (running) //Our MainMenu!! Until we stop the program it will continue to apear 
                {
                    Console.Clear();
                    Console.WriteLine("\n ===Welcome To The Personal Budget Tracker=== ");
                    Console.WriteLine("1. ===Add transaction===");
                    Console.WriteLine("2. ===Show all transactions===");
                    Console.WriteLine("3. ===Show balance===");
                    Console.WriteLine("4. ===Delete last transaction===");
                    Console.WriteLine("5. ===End Program===");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine()!;

                    switch (choice) // our choices
                    { 
                        case "1":
                            Console.Clear();
                            Console.Write("==Enter title: ");
                            string title = Console.ReadLine()!;

                            Console.Write("==Enter category: ");
                            string category = Console.ReadLine()!;

                            Console.Write("==Enter description: ");
                            string description = Console.ReadLine()!;

                            Console.Write("==Enter amount: ");
                            decimal amount = Convert.ToDecimal(Console.ReadLine());

                            Console.Write("==Enter due date (yyyy-mm-dd): ");
                            DateTime dateInput = DateTime.Parse(Console.ReadLine()!); // Parses the user input (string) into a DateTime object
                            Transaction.DueDate dueDate = new Transaction.DueDate(dateInput); 
                            // Wraps the DateTime in a DueDate object for use in the Transaction class 
                            
                            manager.AddTransaction(title, category, description, amount, dueDate); //adds a new transaction to the transactions list
                            Console.WriteLine("Transaction added successfully!\n");
                            Console.WriteLine("Press to continue...");
                            Console.ReadKey();
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Showing all transactions:");
                            manager.ShowAllTransactions(); // Shows all transactions, color coded and ready to be seen
                            Console.WriteLine("Press to continue...");
                            Console.ReadKey();
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("Calculating total of transactions:");
                            manager.CalculateBalance(); // Calculates the Salary and Expenses and then calculates the current balance (Yes I can go into Debt :>)
                            Console.WriteLine("Press to continue...");
                            Console.ReadKey();
                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("Deleting...");
                            manager.DeletedTransaction(); //deletes the last inputted List object
                            Console.WriteLine("Press to continue...");
                            Console.ReadKey();
                            break;

                        case "5":                           
                            Console.WriteLine("Exiting BudgetTracker...");
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Something went wrong!!...");
                            break;

                    }
                } 
            }        
    }
}
