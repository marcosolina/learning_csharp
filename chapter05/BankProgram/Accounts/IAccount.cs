using System.IO;

namespace BankProgram.Accounts
{
    /// <summary>
    /// Simple interface to define a common set of methods
    /// </summary>
    interface IAccount
    {
        /// <summary>
        /// It will add the funds to the balance
        /// </summary>
        /// <param name="amount">The funds to add</param>
        void PayInFunds(decimal amount); 

        /// <summary>
        /// It performs the widthdraw
        /// </summary>
        /// <param name="amount">The amount to withdraw</param>
        /// <returns>status of the operation</returns>
        bool WithdrawFunds(decimal amount); 

        /// <summary>
        /// It returns the currebt balance
        /// </summary>
        /// <returns>The balance value</returns>
        decimal GetBalance(); 

        /// <summary>
        /// It returns the name of the account
        /// </summary>
        /// <returns>The account name</returns>
        string GetName();

        /// <summary>
        /// It sets / updates the account name.
        /// </summary>
        /// <param name="newName">The account name</param>
        /// <returns>Status of the operation</returns>
        /// <exception cref="BankException">It throws an exception if the name is not valid</exception>
        bool SetName(string newName);

        /// <summary>
        /// It stores the account info
        /// </summary>
        /// <param name="textOut">The stream where to write the info into</param>
        void Save(TextWriter textOut);
    }
}
