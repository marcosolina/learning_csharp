using System.Collections.Generic;
using System.IO;

namespace BankProgram
{
    class DictionaryBank
    {
        Dictionary<string, IAccount> accountDictionary = new Dictionary<string, IAccount>();

        public IAccount FindAccount(string name)
        {
            if (accountDictionary.ContainsKey(name) == true)
                return accountDictionary[name];
            else
                return null;
        }

        public bool StoreAccount(IAccount account)
        {
            if (accountDictionary.ContainsKey(account.GetName()) == true)
                return false;

            accountDictionary.Add(account.GetName(), account);
            return true;
        }

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

        public void Save(TextWriter textOut)
        {
            textOut.WriteLine(accountDictionary.Count);
            foreach (CustomerAccount account in accountDictionary.Values)
            {
                textOut.WriteLine(account.GetType().Name);
                account.Save(textOut);
            }
        }

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

        public static DictionaryBank Load(string filename)
        {
            TextReader textIn = null;
            DictionaryBank result = null;
            try
            {
                textIn = new StreamReader(filename);
                result = DictionaryBank.Load(textIn);
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
