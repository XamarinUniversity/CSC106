using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(200);
            BankAccount myWallet = new BankAccount(100);

            int response;
            do
            {
                Console.WriteLine("Menu options:\n1) Deposit to bank\n2) Withdraw from bank\n3) Display amounts\n4) Quit");
                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 4:
                        break;
                    case 1:
                        {
                            transferMoney(myWallet, bankAccount);
                            break;
                        }
                    case 2:
                        {
                            transferMoney(bankAccount, myWallet);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Account amounts:");
                            Console.WriteLine("Bank: " + bankAccount.AmountOfMoney.ToString("C"));
                            Console.WriteLine("Wallet: " + myWallet.AmountOfMoney.ToString("C") + "\n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That is not a valid option");
                            break;
                        }
                }
            } while (response != 4);

        }
        private static void transferMoney(BankAccount fromAccount, BankAccount toAccount)
        {
            Console.WriteLine("Enter amount of money");
            double amount = double.Parse(Console.ReadLine());
            //Do we have enough money in our wallet?
            if (fromAccount.Withdraw(amount))
            {
                toAccount.Desposit(amount);
            }
            else
            {
                Console.WriteLine("\nThere isn't enough money to complete this transaction\n");
            }
        }
    }
}
