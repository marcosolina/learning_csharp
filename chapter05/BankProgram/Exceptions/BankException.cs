using System;

namespace BankProgram.Exceptions
{
    class BankException : Exception
    {
        public BankException(string message) : base(message)
        { }
    }
}
