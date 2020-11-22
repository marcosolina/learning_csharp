
using BankProgram.Accounts;
using System.IO;

namespace BankProgram.Accounts
{
    class AccountFactory
    {
        /// <summary>
        /// It instanciate the specific object
        /// </summary>
        /// <param name="name">The account class name</param>
        /// <param name="textIn">The stream to read the info from</param>
        /// <returns>The instance of the account</returns>
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
