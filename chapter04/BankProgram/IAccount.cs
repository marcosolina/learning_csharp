using System;
using System.Collections.Generic;
using System.Text;

namespace BankProgram
{
    /// <summary>
    /// Interface to define the Account operations
    /// </summary>
    interface IAccount
    {
        void PayInFunds(decimal amount); 
        bool WithdrawFunds(decimal amount); 
        decimal GetBalance();
        string RudeLetterString();
    }
}
