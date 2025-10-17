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

        DueDate Date { get; set; }

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

            Console.WriteLine($"Transcation {title} on the {date} costed you {amount} \nCATEGORY: {category} \nDESCRIPTION: {description}");
        }

    }
}
