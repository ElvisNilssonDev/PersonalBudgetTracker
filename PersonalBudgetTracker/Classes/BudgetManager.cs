using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTracker.Classes
{
    internal class BudgetManager
    {
        private List<Transaction> TransactionList = new List<Transaction>();

        public void AddTransaction(string title, string category, string description, decimal amount, DueDate date)
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
            
            decimal Totalamount = 0;

            foreach (Transaction transaction in TransactionList)
            {
                Totalamount += transaction.Amount;
            }

            Console.WriteLine($"Total Spent:{Totalamount}");
        }

        public void DeletedTransaction()
        {
            TransactionList.Clear(); // clears all but I could do Transactionlist.Remove(obj); to specify.
        }
    }
}
