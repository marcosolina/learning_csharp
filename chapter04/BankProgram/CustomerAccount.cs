using System;
using System.Collections.Generic;
using System.Text;

namespace BankProgram
{
    public class CustomerAccount : AccountClass
    {
        private decimal balance;
        private string name;

        /// <summary>
        /// The default constructor will call my custom constructor
        /// </summary>
        public CustomerAccount() : this("")
        { }

        public CustomerAccount(string name) : this(name, 0)
        { }

        public CustomerAccount(string name, decimal inBalance) : base(name, inBalance)
        { }

        public override string RudeLetterString()
        {
            return "You are overdrawn";
        }

        public static bool AccountAllowed(decimal income, int age)
        {
            return income >= 10000 && age > 17;
        }

    }
}
