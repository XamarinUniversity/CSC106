using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // TODO: Get account information


            // TODO: Print account information (replace ? with variables)

            //PrintAccountInfo(?,?,?)
            
        }
        static void PrintAccountInfo(bool isActive, double balance, DateTime lastDeposit)
        {
            Console.WriteLine("Account is active? {0}", isActive);
            Console.WriteLine("Balance: {0}", balance.ToString("C"));
            Console.WriteLine("Date of last deposit: {0}", lastDeposit);
        }
    }
}
