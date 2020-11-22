using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BankProgram
{
    class BabyAccount : CustomerAccount
    {
        private string parentName;

        public BabyAccount(string newName, decimal initialBalance, string inParentName) : base(newName, initialBalance)
        {
            parentName = inParentName;
        }

        public BabyAccount(TextReader textIn) : base(textIn)
        {
            this.parentName = textIn.ReadLine();
        }

        public string GetParentName()
        {
            return parentName;
        }
        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
            return base.WithdrawFunds(amount);
        }

        public override void Save(TextWriter textOut)
        {
            base.Save(textOut);
            textOut.WriteLine(parentName);
        }

        public static BabyAccount Load(TextReader textIn)
        {
            try
            {
                string name = textIn.ReadLine();
                string balanceText = textIn.ReadLine();
                decimal balance = decimal.Parse(balanceText);
                string parent = textIn.ReadLine();
                return new BabyAccount(name, balance, parent);
            }
            catch
            {
                return null;
            }
        }
    }
}
