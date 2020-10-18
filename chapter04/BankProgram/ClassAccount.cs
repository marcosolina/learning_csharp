using System;
using System.Collections.Generic;
using System.Text;

namespace BankProgram
{
    class ClassAccount
    {
        private decimal balance;
        private string name;

        public ClassAccount() : this("")
        { }

        public ClassAccount(string name)
        {
            this.name = name;
            this.balance = 0;
        }

        public bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance -= amount;
            return true;
        } 

        public void PayInFunds(decimal amount)
        {
            balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public static bool AccountAllowed(decimal income, int age)
        {
            return income >= 10000 && age > 17;   
        }

        public string GetName()
        {
            return name;
        }
    }
}
