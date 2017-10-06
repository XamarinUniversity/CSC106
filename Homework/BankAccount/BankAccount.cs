using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public double AmountOfMoney
        {
            get; private set;
        }

        public BankAccount(double startingAmount = 500)
        {
            AmountOfMoney = startingAmount;
        }

        public void Desposit(double amount)
        {
            AmountOfMoney += amount;
        }

        public bool Withdraw(double amountToWithdraw)
        {
            // Can't overdraft
            if (AmountOfMoney < amountToWithdraw)
                return false;

            AmountOfMoney -= amountToWithdraw;
            return true;
        }
    }
}
