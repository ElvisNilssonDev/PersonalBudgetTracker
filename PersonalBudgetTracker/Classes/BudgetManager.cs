using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PersonalBudgetTracker.Classes
{
    public class BudgetManager
    {
        public List<Transaction> TransactionList = new List<Transaction>();

        public void AddTransaction(string title, string category, string description, decimal amount, Transaction.DueDate date)
        {
            TransactionList.Add(new Transaction(title, category, description, amount, date));
        }

        public void ShowAllTransactions()
        {
            foreach (Transaction transaction in TransactionList)
            {
                transaction.ShowInfo();
            }
        }

        public void CalculateBalance()
        {
            decimal totalIncome = 0m;
            decimal totalExpenses = 0m;

            foreach (Transaction transaction in TransactionList)
            {
                // Treat "salary" as income
                if (transaction.Category.Equals("salary", StringComparison.OrdinalIgnoreCase))
                {
                    totalIncome += transaction.Amount;
                }
                else
                {
                    totalExpenses += transaction.Amount;
                }
            }

            Console.WriteLine($"Total Income (Salary): {totalIncome}\n");
            Console.WriteLine($"Total Expenses (All Others): {totalExpenses}\n");
            Console.WriteLine($"Net Balance: {totalIncome - totalExpenses}\n");
        }


        public void DeletedTransaction()
        {
            if (TransactionList.Count > 0) // always check to avoid errors with going below. cant take away what you dont have.
            {
                TransactionList.RemoveAt(TransactionList.Count - 1);
                Console.WriteLine("Last transaction removed.");
            } 
        }
    }
}
