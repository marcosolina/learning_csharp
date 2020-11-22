using System;

namespace BankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerAccount test = new CustomerAccount("Rob", 1000000);
            test.Save("Test.txt");
            CustomerAccount loaded = CustomerAccount.Load("Test.txt");
            Console.WriteLine(loaded.GetName());
        }
    }
}
