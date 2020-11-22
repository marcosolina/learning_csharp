
using System.IO;

namespace BankProgram
{
    class CustomerAccount : IAccount
    {
        private decimal balance = 0;
        private string name;

        public CustomerAccount(string newName, decimal initialBalance)
        {
            this.name = newName;
            this.balance = initialBalance;
        }

        public CustomerAccount(TextReader textIn)
        {
            this.name = textIn.ReadLine();
            string balanceText = textIn.ReadLine();
            this.balance = decimal.Parse(balanceText);
        }

        public virtual bool WithdrawFunds(decimal amount)
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

        public string GetName()
        {
            return name;
        }

        public static CustomerAccount Load(TextReader textIn)
        {
            try
            {
                string name = textIn.ReadLine();
                string balanceText = textIn.ReadLine();
                decimal balance = decimal.Parse(balanceText);
                return new CustomerAccount(name, balance);
            }
            catch
            {
                return null;
            }
        }

        public virtual void Save(TextWriter textOut)
        {
            textOut.WriteLine(name);
            textOut.WriteLine(balance);
        }
    }
}
