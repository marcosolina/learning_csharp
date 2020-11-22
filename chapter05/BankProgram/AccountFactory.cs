
using System.IO;

namespace BankProgram
{
    class AccountFactory
    {
        public static IAccount MakeAccount(string name, TextReader textIn)
        {
            switch (name)
            {
                case "CustomerAccount":
                    return new CustomerAccount(textIn);
                case "BabyAccount":
                    return new BabyAccount(textIn);
                default:
                    return null;
            }
        }
    }
}
