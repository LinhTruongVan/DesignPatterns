using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingAccountFactory() as ISavingAccountFactory;

            var citiSavingAccount = factory.GetSavingAccount("CITI-111");
            var nationalSavingAccount = factory.GetSavingAccount("NATIONAL-222");

            Console.WriteLine("Citi account balance: {0}$", citiSavingAccount.Balance);
            Console.WriteLine("National account balance: {0}$", nationalSavingAccount.Balance);
        }
    }
}
