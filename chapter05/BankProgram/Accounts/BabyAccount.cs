using System.IO;

namespace BankProgram.Accounts
{

    /// <summary>
    /// Account for under age
    /// </summary>
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

        public override string ToString()
        {
            return base.ToString() + " Parent: " + this.parentName;
        }

    }
}
