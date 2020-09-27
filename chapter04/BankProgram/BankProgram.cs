using System;

namespace BankProgram
{
    class BankProgram
    {
        static void Main(string[] args)
        {
            const int MAX_CUSTOMER = 100;
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
        }

        public static void PrintAccount(Account account)
        {
            Console.WriteLine($"Name: {account.Name}");
            Console.WriteLine($"Address: {account.Address}");
            Console.WriteLine($"Balance: {account.Balance}");
        }
    }
}
