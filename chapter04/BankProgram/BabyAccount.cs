using System;
using System.Collections.Generic;
using System.Text;

namespace BankProgram
{
    class BabyAccount : IAccount
    {
        private decimal balance = 0;
        public bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
