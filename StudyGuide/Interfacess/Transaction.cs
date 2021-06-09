using System;
namespace Interfacess
{
    public class Transaction: ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction() {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a) {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount() {
            return amount;
        }
        public void showTransaction() {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
        
    }
}