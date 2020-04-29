using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekdlab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double curBal = 45.32;

            double amount;
            Console.Write("Please enter a amount to update account by $");
            amount = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Customer's balance (before transaction) = $");
            Console.WriteLine(curBal + "\n");
            Console.Write("Requested update amount = $");
            Console.WriteLine(amount + "\n");

            double actAmount;
            actAmount = transaction(curBal, amount);
            curBal += actAmount;

            Console.Write("Actual update amount = $");
            Console.WriteLine(actAmount + "\n");
            Console.Write("Customer's balance (after transaction) = $");
            Console.WriteLine(curBal + "\n");

            Console.WriteLine("\nThank you and good-bye!\n");
            Console.Read();
        }

        public static double transaction(double bal, double amount)
        {
            if(bal + amount < 0){
                return bal;
            } else {
                return amount;
            }
        }
    }
}