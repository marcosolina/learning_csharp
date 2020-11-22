using System.IO;

namespace BankProgram
{
    interface IAccount
    {
        void PayInFunds(decimal amount); 
        bool WithdrawFunds(decimal amount); 
        decimal GetBalance(); 
        string GetName();

        void Save(TextWriter textOut);
    }
}
