using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTracker.Classes
{
    public class Transaction
    {      
        public decimal Amount { get; private set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public DueDate Date { get; private set; }
        

        public Transaction(string title, string category, string description, decimal amount, DueDate date)
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

            // Set color based on description
            var categoryColors = new Dictionary<string, ConsoleColor>(StringComparer.OrdinalIgnoreCase)
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
                Console.ForegroundColor = ConsoleColor.White; // default
            }

            Console.WriteLine($"|{amount}:kr|{title}| - |{date}|\nCATEGORY: {category} \nDESCRIPTION: {description}\n");

            Console.ResetColor();
        }

        public class DueDate
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
