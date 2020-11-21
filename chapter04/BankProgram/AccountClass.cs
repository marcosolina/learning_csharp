using System;
using System.Collections.Generic;
using System.Text;

namespace BankProgram
{
    public abstract class AccountClass : IAccount
    {
        private decimal balance = 0;
        private string name;

        public AccountClass(string name, decimal inBalance)
        {
            this.name = name;
            this.balance = inBalance;
        }

        public abstract string RudeLetterString();

        public override string ToString()
        {
            return "Name: " + name + " balance: " + balance;
        }

        /*
         * Virtual meands that the method can be overwritten
         */
        public virtual bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount; return true;
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}


