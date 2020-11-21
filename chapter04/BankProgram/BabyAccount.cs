using System;
using System.Collections.Generic;
using System.Text;

namespace BankProgram
{
    /*
     * This class extends CustomerAccuont and implements IAccount
     */
    class BabyAccount : AccountClass
    {

        public BabyAccount() : this("", 0)
        { }

        public BabyAccount(string name, decimal inBalance) : base(name, inBalance)
        { }

        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }

            return base.WithdrawFunds(amount);
        }

        public override string RudeLetterString()
        {
            return "Tell daddy you are overdrawn";
        }
    }
}
