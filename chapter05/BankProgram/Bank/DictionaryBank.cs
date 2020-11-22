using BankProgram.Accounts;
using System.Collections.Generic;
using System.IO;

namespace BankProgram.Bank
{
    /// <summary>
    /// It represents the Bank
    /// </summary>
    class DictionaryBank
    {
        Dictionary<string, IAccount> accountDictionary = new Dictionary<string, IAccount>();

        /// <summary>
        /// Finds the account by name
        /// </summary>
        /// <param name="name">The name of the account</param>
        /// <returns>The account or null</returns>
        public IAccount FindAccount(string name)
        {
            if (accountDictionary.ContainsKey(name) == true)
                return accountDictionary[name];
            else
                return null;
        }

        /// <summary>
        /// It adds the account into the system
        /// </summary>
        /// <param name="account">The account to store</param>
        /// <returns>The status of the operation</returns>
        public bool StoreAccount(IAccount account)
        {
            if (accountDictionary.ContainsKey(account.GetName()) == true)
                return false;

            accountDictionary.Add(account.GetName(), account);
            return true;
        }

        /// <summary>
        /// Persist the Bank info into a file
        /// </summary>
        /// <param name="filename">The file name</param>
        /// <returns>The status of the operation</returns>
        public bool Save(string filename)
        {
            TextWriter textOut = null;
            try
            {
                textOut = new StreamWriter(filename);
                Save(textOut);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
            return true;
        }

        /// <summary>
        /// It saves the Bank info using the provided stream
        /// </summary>
        /// <param name="textOut">The stream</param>
        public void Save(TextWriter textOut)
        {
            textOut.WriteLine(accountDictionary.Count);
            foreach (CustomerAccount account in accountDictionary.Values)
            {
                textOut.WriteLine(account.GetType().Name);
                account.Save(textOut);
            }
        }

        /// <summary>
        /// It loads the Bank info from the provided stream
        /// </summary>
        /// <param name="textIn">The stream to load the bank from</param>
        /// <returns>The DictionaryBank object</returns>
        public static DictionaryBank Load(TextReader textIn)
        {
            DictionaryBank result = new DictionaryBank();
            string countString = textIn.ReadLine();
            int count = int.Parse(countString);

            for (int i = 0; i < count; i++)
            {

                string className = textIn.ReadLine();
                IAccount account = AccountFactory.MakeAccount(className, textIn);
                result.accountDictionary.Add(account.GetName(), account);
            }
            return result;
        }


        /// <summary>
        /// It loads the Bank info from the provided file name
        /// </summary>
        /// <param name="filename">The file name that contains the Bank info</param>
        /// <returns>The DictionaryBank object</returns>
        public static DictionaryBank Load(string filename)
        {
            TextReader textIn = null;
            DictionaryBank result = null;
            try
            {
                textIn = new StreamReader(filename);
                result = Load(textIn);
            }
            catch
            {
                return null;
            }
            finally
            {
                if (textIn != null)
                    textIn.Close();
            }

            return result;
        }
    }
}
