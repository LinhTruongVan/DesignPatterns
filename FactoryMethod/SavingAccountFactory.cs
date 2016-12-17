using System;

namespace FactoryMethod
{
    public class SavingAccountFactory : ISavingAccountFactory
    {
        public SavingAccount GetSavingAccount(string accountNumber)
        {
            if (accountNumber.StartsWith("CITI"))
            {
                return new CitiSavingAccount();
            }
            if (accountNumber.StartsWith("NATIONAL"))
            {
                return new NationalSavingAccount();
            }
            throw new ArgumentException("Invalid account number!");
        }
    }
}