using System;

namespace BankProgram
{
    class BankProgram
    {
        static void Main(string[] args)
        {
            const int MAX_CUSTOMER = 100;
            /*
             * Account it's a struct
             */
            Account[] Bank = new Account[MAX_CUSTOMER];

            Bank[0].Name = "Marco";
            Bank[0].Address = "Marco's house";
            Bank[0].State = AccountState.Active;
            Bank[0].Balance = 10000;
            PrintAccount(Bank[0]);

            Bank[1].Name = "Marco2";
            Bank[1].Address = "Marco's house2";
            Bank[1].State = AccountState.Frozen;
            Bank[1].Balance = 20000;
            PrintAccount(Bank[1]);

            IAccount customerAccount = new CustomerAccount();
            customerAccount.PayInFunds(50);

            Console.WriteLine(customerAccount.WithdrawFunds(10));
            Console.WriteLine(CustomerAccount.AccountAllowed(1234, 5));

            CustomerAccount classAccount2 = new CustomerAccount("Test");
            Console.WriteLine((customerAccount as CustomerAccount).GetName());
            Console.WriteLine(classAccount2.GetName());

            Console.WriteLine("Customer Balance: " + customerAccount.GetBalance());
            Console.WriteLine("Customer Withdraw 20 status:" + customerAccount.WithdrawFunds(20));

            IAccount babyAccount = new BabyAccount();
            babyAccount.PayInFunds(20);
            Console.WriteLine("Baby Balance: " + babyAccount.GetBalance());
            Console.WriteLine("Baby Withdraw 20 status:" + babyAccount.WithdrawFunds(20));
        }

        public static void PrintAccount(Account account)
        {
            Console.WriteLine($"Name: {account.Name}");
            Console.WriteLine($"Address: {account.Address}");
            Console.WriteLine($"Balance: {account.Balance}");
        }
    }
}
