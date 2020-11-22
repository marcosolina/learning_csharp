using BankProgram.Exceptions;
using System.IO;

namespace BankProgram.Accounts
{
    /// <summary>
    /// This class provides the default business logic for all the accounts
    /// </summary>
    public abstract class Account : IAccount
    {
        private decimal balance = 0;
        private string name;

        protected Account() { }

        public Account(string name, decimal balance)
        {
            ValidateName(name);
            this.name = name;
            this.balance = balance;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }

        public string GetName()
        {
            return this.name;
        }

        public void PayInFunds(decimal amount)
        {
            this.balance += amount;
        }

        public bool SetName(string newName)
        {
            this.name = newName;
            return true;
        }


        /// <summary>
        /// IT validates the account name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Status of the validation</returns>
        /// <exception cref="BankException">It throws an exception if the name is not valid</exception>
        public static bool ValidateName(string name)
        {
            if (name == null)
            {
                throw new BankException("Name null");
            }
            
            if (name.Trim().Length == 0)
            {
                throw new BankException("Invalid Name");
            }
            return true;
        }

        public virtual bool WithdrawFunds(decimal amount)
        {
            if (this.balance < amount)
            {
                return false;
            }
            this.balance -= amount;
            return true;
        }
        public override string ToString()
        {
            return "Account Type: " + this.GetType().Name + " Name: " + name + " balance: " + balance;
        }
        public abstract void Save(TextWriter textOut);
    }
}
