
using System.IO;

namespace BankProgram
{
    class CustomerAccount : IAccount
    {
        private decimal balance = 0;
        private string name;

        public CustomerAccount(string newName, decimal initialBalance)
        {
            name = newName;
            balance = initialBalance;
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

        public bool Save(string filename)
        {
            try
            {
                TextWriter textOut = new StreamWriter(filename);
                textOut.WriteLine(name);
                textOut.WriteLine(balance);
                textOut.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static CustomerAccount Load(string filename)
        {
            CustomerAccount result = null;
            TextReader textIn = null;
            try
            {
                textIn = new StreamReader(filename);
                string nameText = textIn.ReadLine();
                string balanceText = textIn.ReadLine();
                decimal balance = decimal.Parse(balanceText);
                result = new CustomerAccount(nameText, balance);
            }
            catch
            {
                return null;
            }
            finally
            {
                if (textIn != null)
                {
                    textIn.Close();
                }
            }
            return result;
        }
    }
}
