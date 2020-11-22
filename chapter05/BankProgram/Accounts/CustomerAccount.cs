using System.IO;

namespace BankProgram.Accounts
{
    /// <summary>
    /// Standard account
    /// </summary>
    public class CustomerAccount : Account
    {
        public CustomerAccount(string newName, decimal initialBalance) : base(newName, initialBalance)
        {}

        public CustomerAccount(TextReader textIn) : base()
        {
            string name = textIn.ReadLine();
            string balanceText = textIn.ReadLine();
            decimal balance = decimal.Parse(balanceText);
            base.SetName(name);
            base.PayInFunds(balance);
        }

        public override void Save(TextWriter textOut)
        {
            textOut.WriteLine(this.GetName());
            textOut.WriteLine(this.GetBalance());
        }
    }
}
