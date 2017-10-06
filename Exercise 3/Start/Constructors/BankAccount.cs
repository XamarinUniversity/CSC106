using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class BankAccount
    {
        private double balance;
        private DateTime lastDeposit;
        private bool isActive;
        private string accountName;

        // TODO: add constructors

        public string GetAccountInfo()
        {
            return String.Format("{0}:  Balance: {1}. Last Deposit: {2}, IsActive: {3}",
                accountName,
                balance,
                lastDeposit,
                isActive);
        }
    }
}
