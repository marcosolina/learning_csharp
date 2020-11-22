using System;

namespace BankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryBank ourBank = new DictionaryBank();

            CustomerAccount newAccount = new CustomerAccount("Rob", 1000000);
            if (ourBank.StoreAccount(newAccount))
            {
                Console.WriteLine("CustomerAccount added to bank");
            }

            BabyAccount newBabyAccount = new BabyAccount("David", 100, "Rob");
            if (ourBank.StoreAccount(newBabyAccount))
            {
                Console.WriteLine("BabyAccount added to bank");
            }
            ourBank.Save("Test.txt");

            DictionaryBank loadBank = DictionaryBank.Load("Test.txt");
            IAccount storedAccount = loadBank.FindAccount("Rob");

            if (storedAccount != null)
            {
                Console.WriteLine("CustomerAccount found in bank");
            }

            storedAccount = loadBank.FindAccount("David");
            if (storedAccount != null)
            {
                Console.WriteLine("BabyAccount found in bank");
            }
        }
    }
}
