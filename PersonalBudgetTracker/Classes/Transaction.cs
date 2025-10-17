using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTracker.Classes
{
    public class Transaction // Attributes inside my Transaction class
    {      
        public decimal Amount { get; private set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public DueDate Date { get; private set; }
        

        public Transaction(string title, string category, string description, decimal amount, DueDate date) // A Constructor to initialize our attributes
        {
            Title = title;
            Category = category;
            Description = description;
            Amount = amount;
            Date = date;
        }    

        public void ShowInfo()
        {
            string title = Title;

            DueDate date = Date;

            decimal amount = Amount;

            string description = Description;

            string category = Category;

            // Color system for the transactions to show if its a salary or expense or other.
            var categoryColors = new Dictionary<string, ConsoleColor>(StringComparer.OrdinalIgnoreCase) // OrdinalIgnoreCase means it can be type a big or small letter
            {
               { "salary", ConsoleColor.Green },
               { "swish", ConsoleColor.Green },
               { "food", ConsoleColor.Red },
               { "groceries", ConsoleColor.Red },
               { "clothes", ConsoleColor.Red },
               { "shopping", ConsoleColor.Red },
               { "transport", ConsoleColor.Yellow },
               { "entertainment", ConsoleColor.Magenta },
               { "electronics", ConsoleColor.Red },
               { "bill", ConsoleColor.Red },
               { "bills", ConsoleColor.Red },
            };

            // Determine color
            if (categoryColors.TryGetValue(Category, out ConsoleColor color))
            {
                Console.ForegroundColor = color;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White; // default color
            }

            Console.WriteLine($"|{amount}:kr|{title}| - |{date}|\nCATEGORY: {category} \nDESCRIPTION: {description}\n");

            Console.ResetColor(); // reset the color to default
        }

        public class DueDate // had to make a DueDate class for it to work (I had Issues with just typing it as it was)
        {
            public DateTime DateValue { get; set; }

            public DueDate(DateTime date)
            {
                DateValue = date;
            }

            public override string ToString()
            {
                return DateValue.ToShortDateString();
            }
        }

    }
}
