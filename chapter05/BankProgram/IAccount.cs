using System;
using System.Collections.Generic;
using System.Text;

namespace BankProgram
{
    interface IAccount
    {
        void PayInFunds(decimal amount); 
        bool WithdrawFunds(decimal amount); 
        decimal GetBalance(); 
        string GetName();
    }
}
