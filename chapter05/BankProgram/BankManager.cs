using BankProgram.Accounts;
using BankProgram.Bank;
using BankProgram.Exceptions;
using System;

namespace BankProgram
{
    class BankManager
    {
        static void Main(string[] args)
        {
            BankManager bankManager = new BankManager();
            decimal menuOption;
            do
            {
                bankManager.PrintMainMenu();
                menuOption = bankManager.ReadMenuOption();
                bankManager.ExecuteOption(menuOption);
            } while (menuOption != 0);
        }

        private DictionaryBank bank = new DictionaryBank();
        private string bankFileName = "Bank.txt";

        public void PrintMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1) Add a Customer Account");
            Console.WriteLine("2) Add a Baby Account");
            Console.WriteLine("3) Find an account");
            Console.WriteLine("4) Save the Bank");
            Console.WriteLine("5) Load the Bank");
            Console.WriteLine("0) Exit");
        }

        public void AddCustomerAccount()
        {
            string name = getNewAccountName();
            decimal balance = getNewBalance();

            this.bank.StoreAccount(new CustomerAccount(name, balance));
        }

        public void AddBabyCustomerAccount()
        {
            string name = getNewAccountName();
            string parentName = getParentName();
            decimal balance = getNewBalance();

            this.bank.StoreAccount(new BabyAccount(name, balance, parentName));
        }

        public void SaveConfig()
        {
            this.bank.Save(this.bankFileName);
        }

        public void LoadConfig()
        {
            this.bank = DictionaryBank.Load(this.bankFileName);
        }

        public void FindAccount()
        {
            string name = getNewAccountName();
            IAccount account = this.bank.FindAccount(name);
            if(account == null)
            {
                Console.WriteLine("Account not found");
            }
            else
            {
                Console.WriteLine(account);
            }
        }

        public void ExecuteOption(decimal option)
        {
            switch (option)
            {
                case 1:
                    this.AddCustomerAccount();
                    break;
                case 2:
                    this.AddBabyCustomerAccount();
                    break;
                case 3:
                    this.FindAccount();
                    break;
                case 4:
                    this.SaveConfig();
                    break;
                case 5:
                    this.LoadConfig();
                    break;
            }
        }

        private string getNewAccountName()
        {
            string newName;
            while (true)
            {
                Console.Write("Type the account name: ");
                newName = Console.ReadLine();
                try
                {

                    if (Account.ValidateName(newName))
                    {
                        break;
                    }
                }
                catch (BankException e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine();
            return newName;
        }

        private string getParentName()
        {
            string newName;
            while (true)
            {
                Console.Write("Type the Parent account name: ");
                newName = Console.ReadLine();
                try
                {

                    if (Account.ValidateName(newName))
                    {
                        break;
                    }
                }
                catch (BankException e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine();
            return newName;
        }

        private decimal getNewBalance()
        {
            decimal balance;
            while (true)
            {
                Console.Write("Type the initial balance: ");
                string typedBalance = Console.ReadLine();
                if (decimal.TryParse(typedBalance, out balance))
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Invalid Decimal value");
            }

            Console.WriteLine();
            return balance;
        }

        private decimal ReadMenuOption()
        {
            decimal option;
            while (true)
            {
                Console.Write("Type the option number: ");
                string typedBalance = Console.ReadLine();
                if (decimal.TryParse(typedBalance, out option))
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Invalid Decimal value");
            }

            Console.WriteLine();
            return option;
        }

    }
}
